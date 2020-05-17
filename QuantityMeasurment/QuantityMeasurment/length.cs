using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurment
{
    public class length
    {
        //Enum data members
        public enum Unit { Feet, Inch }
        
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
            //Checking Feet and Inch Values Are Equal Or Not in If Block And Vice Versa In Else If Block.
            if (object1.unit.Equals(Unit.Feet) && object2.unit.Equals(Unit.Inch))
            {
                double feetToCm = object1.value * 30.48;
                double inchToCm = object2.value * 2.54;
                if (feetToCm == inchToCm)
                {
                    return true;
                }
            }
            else if (object1.unit.Equals(Unit.Inch) && object2.unit.Equals(Unit.Feet))
            {
                double inchToCm = object1.value * 2.54;
                double feetToCm = object2.value * 30.48;
                if (inchToCm == feetToCm)
                {
                    return true;
                }
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
