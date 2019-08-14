using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RottenVehicle
{
    public interface ISpeed
    {
        int X { get; set; }
        int Y { get; set; }

        void Modify(Acceleration acceleration);
    }
}
