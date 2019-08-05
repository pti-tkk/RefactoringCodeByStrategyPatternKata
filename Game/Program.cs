using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RottenVehicle;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Vehicle vehicle;
            int[] result;

            //Repülőgép teszt
            vehicle = new Vehicle("airplane");
            string airplaneResult = "";

            result = vehicle.Move("up", "atmosphere");
            airplaneResult += result[0].ToString();
            airplaneResult += result[1].ToString();

            result = vehicle.Move("right", "atmosphere");
            airplaneResult += result[0].ToString();
            airplaneResult += result[1].ToString();

            result = vehicle.Move("down", "atmosphere");
            airplaneResult += result[0].ToString();
            airplaneResult += result[1].ToString();

            result = vehicle.Move("left", "atmosphere");
            airplaneResult += result[0].ToString();
            airplaneResult += result[1].ToString();

            result = vehicle.Move("up", "underwater");
            airplaneResult += result[0].ToString();
            airplaneResult += result[1].ToString();

            result = vehicle.Move("right", "underwater");
            airplaneResult += result[0].ToString();
            airplaneResult += result[1].ToString();

            result = vehicle.Move("down", "underwater");
            airplaneResult += result[0].ToString();
            airplaneResult += result[1].ToString();

            result = vehicle.Move("left", "underwater");
            airplaneResult += result[0].ToString();
            airplaneResult += result[1].ToString();

            result = vehicle.Move("up", "surface");
            airplaneResult += result[0].ToString();
            airplaneResult += result[1].ToString();

            result = vehicle.Move("right", "surface");
            airplaneResult += result[0].ToString();
            airplaneResult += result[1].ToString();

            result = vehicle.Move("down", "surface");
            airplaneResult += result[0].ToString();
            airplaneResult += result[1].ToString();

            result = vehicle.Move("left", "surface");
            airplaneResult += result[0].ToString();
            airplaneResult += result[1].ToString();

            Console.WriteLine($"A repülőgép tesztek eredménye: {airplaneResult}");

            //Holdjáró teszt
            vehicle = new Vehicle("rover");
            string roverResult = "";

            result = vehicle.Move("up", "atmosphere");
            roverResult += result[0].ToString();
            roverResult += result[1].ToString();

            result = vehicle.Move("right", "atmosphere");
            roverResult += result[0].ToString();
            roverResult += result[1].ToString();

            result = vehicle.Move("down", "atmosphere");
            roverResult += result[0].ToString();
            roverResult += result[1].ToString();

            result = vehicle.Move("left", "atmosphere");
            roverResult += result[0].ToString();
            roverResult += result[1].ToString();

            result = vehicle.Move("up", "underwater");
            roverResult += result[0].ToString();
            roverResult += result[1].ToString();

            result = vehicle.Move("right", "underwater");
            roverResult += result[0].ToString();
            roverResult += result[1].ToString();

            result = vehicle.Move("down", "underwater");
            roverResult += result[0].ToString();
            roverResult += result[1].ToString();

            result = vehicle.Move("left", "underwater");
            roverResult += result[0].ToString();
            roverResult += result[1].ToString();

            result = vehicle.Move("up", "surface");
            roverResult += result[0].ToString();
            roverResult += result[1].ToString();

            result = vehicle.Move("right", "surface");
            roverResult += result[0].ToString();
            roverResult += result[1].ToString();

            result = vehicle.Move("down", "surface");
            roverResult += result[0].ToString();
            roverResult += result[1].ToString();

            result = vehicle.Move("left", "surface");
            roverResult += result[0].ToString();
            roverResult += result[1].ToString();

            Console.WriteLine($"A holdjáró tesztek eredménye: {roverResult}");

            //Tengeralattjáró teszt
            vehicle = new Vehicle("submarine");
            string submarineResult = "";

            result = vehicle.Move("up", "atmosphere");
            submarineResult += result[0].ToString();
            submarineResult += result[1].ToString();

            result = vehicle.Move("right", "atmosphere");
            submarineResult += result[0].ToString();
            submarineResult += result[1].ToString();

            result = vehicle.Move("down", "atmosphere");
            submarineResult += result[0].ToString();
            submarineResult += result[1].ToString();

            result = vehicle.Move("left", "atmosphere");
            submarineResult += result[0].ToString();
            submarineResult += result[1].ToString();

            result = vehicle.Move("up", "underwater");
            submarineResult += result[0].ToString();
            submarineResult += result[1].ToString();

            result = vehicle.Move("right", "underwater");
            submarineResult += result[0].ToString();
            submarineResult += result[1].ToString();

            result = vehicle.Move("down", "underwater");
            submarineResult += result[0].ToString();
            submarineResult += result[1].ToString();

            result = vehicle.Move("left", "underwater");
            submarineResult += result[0].ToString();
            submarineResult += result[1].ToString();

            result = vehicle.Move("up", "surface");
            submarineResult += result[0].ToString();
            submarineResult += result[1].ToString();

            result = vehicle.Move("right", "surface");
            submarineResult += result[0].ToString();
            submarineResult += result[1].ToString();

            result = vehicle.Move("down", "surface");
            submarineResult += result[0].ToString();
            submarineResult += result[1].ToString();

            result = vehicle.Move("left", "surface");
            submarineResult += result[0].ToString();
            submarineResult += result[1].ToString();

            Console.WriteLine($"A tengeralattjáró tesztek eredménye: {submarineResult}");

            Console.ReadKey();
        }
    }
}
