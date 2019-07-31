using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanVehicle
{
    public class SubmarineSurfaceMoovmentStrategy: IVehicleEnvironmentMoovmentStrategy
    {
        public Tuple<int, int> Moove(int direction)
        {
            return Tuple.Create(0, 0);
        }
    }
}
