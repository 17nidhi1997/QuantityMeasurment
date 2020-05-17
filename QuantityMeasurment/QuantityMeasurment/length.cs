using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurment
{
    public class length:ILength
    {
        //Variables.
        public Unit unit;
        public double value;
        
        //Defauft constructe
        public length()
        { }
       
        // Parameter Constructor To Set Unit And Value.        
        public length(Unit unit, double value)
        {
            this.unit = unit;
            this.value = value;
        }

        // IsEqual Function to Convert Input Units Into Centi-Meter And Checking Their Equality.     
        public bool IsEqual(length object1, length object2)
        {
            try
            {
                double object1ValueInCentimeter = ConvertUnit.ConvertToInch(object1);
                double object2ValueInCentimeter = ConvertUnit.ConvertToInch(object2);
                if (object1ValueInCentimeter == object2ValueInCentimeter)
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
            //If Object is Null It Will Return exception.
            if (obj == null)
            {
                throw new QuantityMeasurementException(QuantityMeasurementException.ExceptionType.Null_Exception, "Null");
            }
            //If Object is Not A Reference Of Length Class The It Will Return False.
            if (!(obj is length))
            {
                return false;
            }
            return (this.unit == ((length)obj).unit) && (this.value == ((length)obj).value) || IsEqual(this, (length)obj);
        }
    }
}
