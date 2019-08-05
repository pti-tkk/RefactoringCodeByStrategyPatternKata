using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanVehicle
{

    public class Vehicle
    {
        private IVehicleEnvironmentMoovmentStrategy moovementStrategy;
        public IVehicleEnvironmentMoovmentStrategy MoovementStrategy
        {
            get { return moovementStrategy; }
            set { moovementStrategy = value; }
        }

        public Tuple<int, int> Move(int direction)
        {
            return moovementStrategy.Moove(direction);
        }
    }
}
