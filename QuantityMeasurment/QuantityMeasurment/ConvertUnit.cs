using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurment
{
    class ConvertUnit
    {
        //Constants
        private static readonly double FEET_TO_INCH_CONVERSION = 12;
        private static readonly double YARD_TO_INCH_CONVERSION = 36;
        private static readonly double CENTIMETER_TO_INCH_CONVERSION = 2.54;
        private static readonly double GALLON_TO_LITRE_CONVERSION = 3.78;
        private static readonly double MILILITRE_TO_LITRE_CONVERSION = 1000;

        // Function To Covert Given Objects Unit Value Into Inch Unit.
        public static double ConvertToInch(length objectName)
        {
            double value = objectName.value;
            try
            {
                //If Else Block for checking the specified Unit and converting into Inch.
                if (objectName.unit.Equals(Unit.Feet))
                {
                    value = objectName.value * FEET_TO_INCH_CONVERSION;
                }
                else if (objectName.unit.Equals(Unit.Yard))
                {
                    value = objectName.value * YARD_TO_INCH_CONVERSION;
                }
                else if (objectName.unit.Equals(Unit.Centimeter))
                {
                    value = Math.Round(objectName.value / CENTIMETER_TO_INCH_CONVERSION);
                }
            }
            catch (QuantityMeasurementException)
            {
                throw new QuantityMeasurementException(QuantityMeasurementException.ExceptionType.INVALID_TYPE, "Invalid");
            }
            return value;
        }
        //Add the length
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

        // Function to Convert Volume Into Litre.
        public static double ConvertToLitre(Volume objectName)
        {
            double value = objectName.value;
            try
            {
                if (objectName.unit.Equals(Unit.Gallon))
                {
                    value = objectName.value * GALLON_TO_LITRE_CONVERSION;
                }
                if (objectName.unit.Equals(Unit.Mililitre))
                {
                    value = objectName.value / MILILITRE_TO_LITRE_CONVERSION;
                }
            }
            catch (QuantityMeasurementException)
            {
                throw new QuantityMeasurementException(QuantityMeasurementException.ExceptionType.INVALID_TYPE, "Invalid Type");
            }
            return value;
        }

        // Function to Add Volumes And result into Litre.
        public static double AddVolumes(Volume object1, Volume object2)
        {
            try
            {
                double value1 = ConvertToLitre(object1);
                double value2 = ConvertToLitre(object2);
                return value1 + value2;
            }
            catch (QuantityMeasurementException)
            {
                throw new QuantityMeasurementException(QuantityMeasurementException.ExceptionType.INVALID_TYPE, "Invalid Type");
            }
        }
    }
}
