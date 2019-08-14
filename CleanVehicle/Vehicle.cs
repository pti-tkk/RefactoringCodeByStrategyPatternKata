namespace CleanVehicle
{

    public class Vehicle : IVehicle
    {
        public IVehicleEnvironmentAccelerationStrategy AccelerationStrategy { get; set; }
        public ISpeed Speed { get; set; }

        public Vehicle(ISpeed initialSpeed)
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
