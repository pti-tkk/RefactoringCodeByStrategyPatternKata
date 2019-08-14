using System.Collections.Generic;

namespace CleanVehicle
{
    public abstract class AVehicleEnvironmentAccelerationStrategy: IVehicleEnvironmentAccelerationStrategy
    {
        public Acceleration[] Accelerations { get; set; }

        public Acceleration Accelerate(int direction)
        {
            return Accelerations[direction];
        }
    }
}
