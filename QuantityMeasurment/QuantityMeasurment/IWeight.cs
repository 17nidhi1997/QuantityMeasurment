using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurment
{
    interface IWeight
    { 
        // Abstract Function For Checking Equal Values Implemenattion.
        public abstract bool IsEqual(Weight object1, Weight object2);
    }
}
