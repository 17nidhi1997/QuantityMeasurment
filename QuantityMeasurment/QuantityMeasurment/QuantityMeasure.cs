using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class QuantityMeasure
    {
        //Variables.
        public Unit unit;
        public double value;

        public QuantityMeasure()
        { }
        // Parameter Constructor To Set Unit And Value.        
        public QuantityMeasure(Unit unit, double value)
        {
            this.unit = unit;
            this.value = value;
        }
        /// Overriding Equals Function.        
        public override bool Equals(object obj)
        {
            //If Object is Null It Will Return exception.
            if (obj == null)
            {
                throw new QuantityMeasurementException(QuantityMeasurementException.ExceptionType.Null_Exception, "Null");
            }
            //If Object is Not A Reference Of Length Class The It Will Return False.
            if (!(obj is QuantityMeasure))
            {
                return false;
            }
            //If Object is Not equal to type of the class then return exception.
            if (this.GetType()!=obj.GetType())
            {
                throw new QuantityMeasurementException(QuantityMeasurementException.ExceptionType.INVALID_TYPE, "");
            }
            QuantityMeasure that = (QuantityMeasure)obj;
            return double.Equals(that.unit.GetConvertedValue(that.value),this.unit.GetConvertedValue(this.value));
        }
        public QuantityMeasure addQuantityMeasure(QuantityMeasure that)
        {
            return new QuantityMeasure(Unit.Litre, this.unit.GetConvertedValue(this.value) + that.unit.GetConvertedValue(that.value));
        }
    }
}
