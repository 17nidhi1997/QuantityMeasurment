using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurment
{
    public class Temperature : ITemperature
    {
        //Variables.
        public Unit unit;
        public double value;

        // Parameter Constructor For Setting Data.       
        public Temperature(Unit unit, double value)
        {
            this.unit = unit;
            this.value = value;
        }

        // Function For Equating Object's Values.        
        public bool IsEqual(Temperature object1, Temperature object2)
        {
            try
            {
                double object1ValueInLitre = ConvertUnit.ConvertToCelsius(object1);
                double object2ValueInLitre = ConvertUnit.ConvertToCelsius(object2);
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
                return false;
            }
            if (!(obj is Temperature))
            {
                return false;
            }
            return (this.unit == ((Temperature)obj).unit && this.value == ((Temperature)obj).value) || IsEqual(this, (Temperature)obj);
        }
    }
}
