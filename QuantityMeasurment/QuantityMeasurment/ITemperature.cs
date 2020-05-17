using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurment
{
    interface ITemperature
    {
        // Abstract Function For Equating Object's Values.
        public abstract bool IsEqual(Temperature object1, Temperature object2);
    }
}