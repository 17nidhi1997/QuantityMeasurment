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
                else if (objectName.unit.Equals(length.Unit.Centimeter))
                {
                    value = Math.Round(objectName.value / 2.54);
                }
            }
            catch (Exception)
            {
                throw new QuantityMeasurementException(QuantityMeasurementException.ExceptionType.INVALID_TYPE, "Invalid");
            }
            return value;
        }
        //Add length to units
        public double AddLengths(length object1, length object2)
        {
            try
            {
                double value1 = ConvertToInch(object1);
                double value2 = ConvertToInch(object2);
                return value1 + value2;
            }
            catch (QuantityMeasurementException)
            {
                throw new QuantityMeasurementException(QuantityMeasurementException.ExceptionType.INVALID_TYPE, "Invalid Type");
            }
        }
    }
}
