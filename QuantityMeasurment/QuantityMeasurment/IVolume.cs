using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurment
{
    interface IVolume
    { 
        // Abstract Function For Equality check.
        public abstract bool IsEqual(Volume object1, Volume object2);
    }
}
