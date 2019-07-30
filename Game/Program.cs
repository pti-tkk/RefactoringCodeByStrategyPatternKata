using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayerComponent.Domain;
using PlayerComponent.Interfaces;
using RottenVehicle;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("airplane");
            int[] dimensions = vehicle.Move("up", "atmosphere");

            Console.WriteLine($"X: {dimensions[0]}");
            Console.WriteLine($"Y: {dimensions[1]}");

            dimensions = vehicle.Move("down", "atmosphere");

            Console.WriteLine($"X: {dimensions[0]}");
            Console.WriteLine($"Y: {dimensions[1]}");

            dimensions = vehicle.Move("left", "atmosphere");

            Console.WriteLine($"X: {dimensions[0]}");
            Console.WriteLine($"Y: {dimensions[1]}");

            dimensions = vehicle.Move("right", "atmosphere");

            Console.WriteLine($"X: {dimensions[0]}");
            Console.WriteLine($"Y: {dimensions[1]}");

            Console.ReadKey();
        }
    }
}
