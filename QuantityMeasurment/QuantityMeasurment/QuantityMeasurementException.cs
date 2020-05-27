using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class QuantityMeasurementException : Exception
    {
        /// <summary>
        /// Enum class
        /// </summary>
        public enum ExceptionType
        {
            INVALID_TYPE,
            Null_Exception
        }
        readonly ExceptionType type;       
        public QuantityMeasurementException(QuantityMeasurementException.ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}