using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayerComponent.Domain;
using PlayerComponent.Interfaces;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlayer player = new Player();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(player.GetSkillLevel("a"));
            }

            Console.ReadKey();
        }
    }
}
