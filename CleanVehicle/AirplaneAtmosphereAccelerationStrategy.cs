using System.Collections.Generic;

namespace CleanVehicle
{
    public class AirplaneAtmosphereAccelerationStrategy : AVehicleEnvironmentAccelerationStrategy
    {
        public AirplaneAtmosphereAccelerationStrategy()
        {
            Accelerations = new Acceleration[]
            {
                new Acceleration(0, 5),
                new Acceleration(3, 3),
                new Acceleration(7, 0),
                new Acceleration(3, -3),
                new Acceleration(0, -7),
                new Acceleration(-3, -3),
                new Acceleration(-7, 0),
                new Acceleration(-3, 3)
            };
        }
    }
}
