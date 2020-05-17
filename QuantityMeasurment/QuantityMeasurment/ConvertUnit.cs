using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurment
{ 
    class ConvertUnit
    {
        public static double ConvertToInch(length objectName)
        {
            double value = objectName.value;
            try
            {
                //If Else Block for checking the specified Unit and converting into Centimeter.
                if (objectName.unit.Equals(length.Unit.Feet))
                {
                    value = objectName.value * 12;
                }
                else if (objectName.unit.Equals(length.Unit.Yard))
                {
                    value = objectName.value * 36;
                }
            }
            catch (Exception)
            {
                throw new QuantityMeasurementException(QuantityMeasurementException.ExceptionType.INVALID_TYPE, "Invalid");
            }
            return value;
        }
    }
}
