using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanVehicle
{
    public class RoverSurfaceMoovmentStrategy : IVehicleEnvironmentMoovmentStrategy
    {
        public Tuple<int, int> Moove(int direction)
        {
            int x = 0;
            int y = 0;

            if (direction == 2)
            {
                x = 2;
            }
            else if (direction == 6)
            {
                x = -2;
            }

            return Tuple.Create(x, y);
        }
    }
}
