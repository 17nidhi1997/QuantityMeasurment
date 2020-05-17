using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurment
{
    public class Weight : IWeight
    {
        //Variables.
        public Unit unit;
        public double value;
        
        // Parameter Constructor For Setting Unit Anf Value.
        public Weight(Unit unit, double value)
        {
            this.unit = unit;
            this.value = value;
        }
        
        // Function To Check Equality Of Two Objects Values.
        public bool IsEqual(Weight object1, Weight object2)
        {
            try
            {
                double object1ValueInLitre = ConvertUnit.ConvertToKiloGram(object1);
                double object2ValueInLitre = ConvertUnit.ConvertToKiloGram(object2);
                if (object1ValueInLitre == object2ValueInLitre)
                {
                    return true;
                }
            }
            catch (Exception)
            {
                throw new QuantityMeasurementException(QuantityMeasurementException.ExceptionType.INVALID_TYPE, "Invalid Type");
            }
            return false;
        }

        // Overriding Equals Function.
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                throw new QuantityMeasurementException(QuantityMeasurementException.ExceptionType.Null_Exception, "Null");
            }
            if (!(obj is Weight))
            {
                return false;
            }
            return (this.unit == ((Weight)obj).unit && this.value == ((Weight)obj).value) || IsEqual(this, (Weight)obj);
        }
    }
}
