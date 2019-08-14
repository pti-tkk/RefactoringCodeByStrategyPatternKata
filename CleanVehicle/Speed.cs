namespace CleanVehicle
{
    public class Speed : ISpeed
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Max { get; private set; }

        public Speed(int max = 200, int x = 0, int y = 0)
        {
            Max = max;
            X = x;
            Y = y;
        }

        public void Modify(Acceleration acceleration)
        {
            X += acceleration.X;
            Y += acceleration.Y;

            if (X <= -Max) X = -Max;
            if (Y <= -Max) Y = -Max;

            if (X >= Max) X = Max;
            if (Y >= Max) Y = Max;
        }

        public void Reset()
        {
            X = 0;
            Y = 0;
        }
    }
}
