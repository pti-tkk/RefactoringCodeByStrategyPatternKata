using PlayerComponent.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerComponent.Domain
{
    public class Player : IPlayer
    {
        private static Random rnd = new Random();

        public int GetLevel()
        {
            return rnd.Next(1, 61);
        }

        public int GetSkillLevel(string skill)
        {
            return rnd.Next(0, 11);
        }
    }
}
