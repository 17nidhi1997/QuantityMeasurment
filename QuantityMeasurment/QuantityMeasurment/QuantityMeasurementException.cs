using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurment
{
    public class QuantityMeasurementException : Exception
    {
        // Enum For Defining Custom Exceptions
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
