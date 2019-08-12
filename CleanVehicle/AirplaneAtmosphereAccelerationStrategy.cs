using System.Collections.Generic;

namespace CleanVehicle
{
    public class AirplaneAtmosphereAccelerationStrategy : AVehicleEnvironmentAccelerationStrategy
    {
        public AirplaneAtmosphereAccelerationStrategy()
        {
            Accelerations = new Dictionary<int, Acceleration>
            {
                {0, new Acceleration(0, 5)},
                {1, new Acceleration(3, 3)},
                {2, new Acceleration(7, 0)},
                {3, new Acceleration(3, -3)},
                {4, new Acceleration(0, -7)},
                {5, new Acceleration(-3, -3)},
                {6, new Acceleration(-7, 0)},
                {7, new Acceleration(-3, 3)}
            };
        }
    }
}
