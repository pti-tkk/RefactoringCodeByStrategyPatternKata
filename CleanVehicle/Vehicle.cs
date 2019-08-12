namespace CleanVehicle
{

    public class Vehicle
    {
        public IVehicleEnvironmentAccelerationStrategy AccelerationStrategy { get; set; }
        public Speed Speed { get; set; }

        public Vehicle(Speed initialSpeed)
        {
            Speed = initialSpeed;
        }

        public void Accelerate(int direction)
        {
            Speed.Modify(AccelerationStrategy.Accelerate(direction));
        }

        public void Reset()
        {
            Speed.Reset();
        }

    }
}
