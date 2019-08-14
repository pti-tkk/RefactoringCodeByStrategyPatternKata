using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RottenVehicle
{
    public class Speed : ISpeed
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Speed(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }

        public void Modify(Acceleration acceleration)
        {
            X += acceleration.X;
            Y += acceleration.Y;
        }
    }
}
