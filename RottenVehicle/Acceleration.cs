using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RottenVehicle
{
    public class Acceleration
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Acceleration(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
