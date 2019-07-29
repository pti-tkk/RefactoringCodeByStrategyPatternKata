using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerComponent.Interfaces
{
    public interface IPlayer
    {
        int GetLevel();
        int GetSkillLevel(string skill);
    }
}
