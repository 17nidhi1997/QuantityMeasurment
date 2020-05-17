using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurment
{
    public class Volume : IVolume
    {
        //Variables.
        public Unit unit;
        public double value;

        // Parameter Constructor for Setting Data.
        public Volume(Unit unit, double value)
        {
            this.unit = unit;
            this.value = value;
        }

        // Function For Checking Equality Of Volumes.       
        public bool IsEqual(Volume object1, Volume object2)
        {
            try
            {

                double object1ValueInLitre = ConvertUnit.ConvertToLitre(object1);
                double object2ValueInLitre = ConvertUnit.ConvertToLitre(object2);
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
            if (!(obj is Volume))
            {
                return false;
            }
            return (this.unit == ((Volume)obj).unit && this.value == ((Volume)obj).value) || IsEqual(this, (Volume)obj);
        }
    }
}