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

            result = vehicle.Move("up", "atmosphere");
            Console.WriteLine($"A repülőgép sebessége a levegőben a fölfelé nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("right", "atmosphere");
            Console.WriteLine($"A repülőgép sebessége a levegőben a jobbra nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("down", "atmosphere");
            Console.WriteLine($"A repülőgép sebessége a levegőben a lefelé nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("left", "atmosphere");
            Console.WriteLine($"A repülőgép sebessége a levegőben a balra nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("up", "underwater");
            Console.WriteLine($"A repülőgép sebessége a víz alatt a fölfelé nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("right", "underwater");
            Console.WriteLine($"A repülőgép sebessége a víz alatt a jobbra nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("down", "underwater");
            Console.WriteLine($"A repülőgép sebessége a víz alatt a lefelé nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("left", "underwater");
            Console.WriteLine($"A repülőgép sebessége a víz alatt a balra nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("up", "water");
            Console.WriteLine($"A repülőgép sebessége a vízen a fölfelé nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("right", "water");
            Console.WriteLine($"A repülőgép sebessége a vízen a jobbra nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("down", "water");
            Console.WriteLine($"A repülőgép sebessége a vízen a lefelé nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("left", "water");
            Console.WriteLine($"A repülőgép sebessége a vízen a balra nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("up", "surface");
            Console.WriteLine($"A repülőgép sebessége a szárazföldön a fölfelé nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("right", "surface");
            Console.WriteLine($"A repülőgép sebessége a szárazföldön a jobbra nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("down", "surface");
            Console.WriteLine($"A repülőgép sebessége a szárazföldön a lefelé nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("left", "surface");
            Console.WriteLine($"A repülőgép sebessége a szárazföldön a balra nyíl hatására így változik: x={result[0]}, y={result[1]}");

            //Holdjáró teszt
            Console.WriteLine();
            vehicle = new Vehicle("rover");

            result = vehicle.Move("up", "atmosphere");
            Console.WriteLine($"A holdjáró sebessége a levegőben a fölfelé nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("right", "atmosphere");
            Console.WriteLine($"A holdjáró sebessége a levegőben a jobbra nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("down", "atmosphere");
            Console.WriteLine($"A holdjáró sebessége a levegőben a lefelé nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("left", "atmosphere");
            Console.WriteLine($"A holdjáró sebessége a levegőben a balra nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("up", "underwater");
            Console.WriteLine($"A holdjáró sebessége a víz alatt a fölfelé nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("right", "underwater");
            Console.WriteLine($"A holdjáró sebessége a víz alatt a jobbra nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("down", "underwater");
            Console.WriteLine($"A holdjáró sebessége a víz alatt a lefelé nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("left", "underwater");
            Console.WriteLine($"A holdjáró sebessége a víz alatt a balra nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("up", "water");
            Console.WriteLine($"A holdjáró sebessége a vízen a fölfelé nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("right", "water");
            Console.WriteLine($"A holdjáró sebessége a vízen a jobbra nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("down", "water");
            Console.WriteLine($"A holdjáró sebessége a vízen a lefelé nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("left", "water");
            Console.WriteLine($"A holdjáró sebessége a vízen a balra nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("up", "surface");
            Console.WriteLine($"A holdjáró sebessége a szárazföldön a fölfelé nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("right", "surface");
            Console.WriteLine($"A holdjáró sebessége a szárazföldön a jobbra nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("down", "surface");
            Console.WriteLine($"A holdjáró sebessége a szárazföldön a lefelé nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("left", "surface");
            Console.WriteLine($"A holdjáró sebessége a szárazföldön a balra nyíl hatására így változik: x={result[0]}, y={result[1]}");

            //Hajó teszt
            Console.WriteLine();
            vehicle = new Vehicle("ship");

            result = vehicle.Move("up", "atmosphere");
            Console.WriteLine($"A hajó sebessége a levegőben a fölfelé nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("right", "atmosphere");
            Console.WriteLine($"A hajó sebessége a levegőben a jobbra nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("down", "atmosphere");
            Console.WriteLine($"A hajó sebessége a levegőben a lefelé nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("left", "atmosphere");
            Console.WriteLine($"A hajó sebessége a levegőben a balra nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("up", "underwater");
            Console.WriteLine($"A hajó sebessége a víz alatt a fölfelé nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("right", "underwater");
            Console.WriteLine($"A hajó sebessége a víz alatt a jobbra nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("down", "underwater");
            Console.WriteLine($"A hajó sebessége a víz alatt a lefelé nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("left", "underwater");
            Console.WriteLine($"A hajó sebessége a víz alatt a balra nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("up", "water");
            Console.WriteLine($"A hajó sebessége a vízen a fölfelé nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("right", "water");
            Console.WriteLine($"A hajó sebessége a vízen a jobbra nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("down", "water");
            Console.WriteLine($"A hajó sebessége a vízen a lefelé nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("left", "water");
            Console.WriteLine($"A hajó sebessége a vízen a balra nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("up", "surface");
            Console.WriteLine($"A hajó sebessége a szárazföldön a fölfelé nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("right", "surface");
            Console.WriteLine($"A hajó sebessége a szárazföldön a jobbra nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("down", "surface");
            Console.WriteLine($"A hajó sebessége a szárazföldön a lefelé nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("left", "surface");
            Console.WriteLine($"A hajó sebessége a szárazföldön a balra nyíl hatására így változik: x={result[0]}, y={result[1]}");

            //Tengeralattjáró teszt
            Console.WriteLine();
            vehicle = new Vehicle("submarine");

            result = vehicle.Move("up", "atmosphere");
            Console.WriteLine($"A tengeralattjáró sebessége a levegőben a fölfelé nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("right", "atmosphere");
            Console.WriteLine($"A tengeralattjáró sebessége a levegőben a jobbra nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("down", "atmosphere");
            Console.WriteLine($"A tengeralattjáró sebessége a levegőben a lefelé nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("left", "atmosphere");
            Console.WriteLine($"A tengeralattjáró sebessége a levegőben a balra nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("up", "underwater");
            Console.WriteLine($"A tengeralattjáró sebessége a víz alatt a fölfelé nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("right", "underwater");
            Console.WriteLine($"A tengeralattjáró sebessége a víz alatt a jobbra nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("down", "underwater");
            Console.WriteLine($"A tengeralattjáró sebessége a víz alatt a lefelé nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("left", "underwater");
            Console.WriteLine($"A tengeralattjáró sebessége a víz alatt a balra nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("up", "water");
            Console.WriteLine($"A tengeralattjáró sebessége a vízen a fölfelé nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("right", "water");
            Console.WriteLine($"A tengeralattjáró sebessége a vízen a jobbra nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("down", "water");
            Console.WriteLine($"A tengeralattjáró sebessége a vízen a lefelé nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("left", "water");
            Console.WriteLine($"A tengeralattjáró sebessége a vízen a balra nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("up", "surface");
            Console.WriteLine($"A tengeralattjáró sebessége a szárazföldön a fölfelé nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("right", "surface");
            Console.WriteLine($"A tengeralattjáró sebessége a szárazföldön a jobbra nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("down", "surface");
            Console.WriteLine($"A tengeralattjáró sebessége a szárazföldön a lefelé nyíl hatására így változik: x={result[0]}, y={result[1]}");

            result = vehicle.Move("left", "surface");
            Console.WriteLine($"A tengeralattjáró sebessége a szárazföldön a balra nyíl hatására így változik: x={result[0]}, y={result[1]}");

            Console.ReadKey();
        }
    }
}
