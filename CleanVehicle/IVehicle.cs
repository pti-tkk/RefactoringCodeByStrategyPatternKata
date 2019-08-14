using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanVehicle
{
    public interface IVehicle
    {
        IVehicleEnvironmentAccelerationStrategy AccelerationStrategy { get; set; }
        ISpeed Speed { get; set; }
        void Accelerate(int direction);
        void Reset();
    }
}
