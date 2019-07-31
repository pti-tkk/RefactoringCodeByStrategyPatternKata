using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanVehicle
{
    public interface IVehicleEnvironmentMoovmentStrategy
    {
        Tuple<int, int> Moove(int direction);
    }
}
