using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RottenVehicle
{
    public interface IVehicle
    {
        ISpeed Speed { get; set; }
        void Accelerate(int direction);
    }
}
