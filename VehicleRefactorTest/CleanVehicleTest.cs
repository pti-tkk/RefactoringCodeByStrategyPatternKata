using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CleanVehicle;

namespace VehicleRefactorTest
{
    [TestClass]
    public class CleanVehicleTest
    {
        [TestMethod]
        public void TestOriginalState()
        {
            Vehicle vehicle;
            Tuple<int, int> result;

            //Tengeralattjáró teszt
            vehicle = new Vehicle();

            vehicle.MoovementStrategy = new SubmarineAtmosphereMoovmentStrategy();
            string submarineResult = "";

            result = vehicle.Move(0);
            submarineResult += result.Item1.ToString();
            submarineResult += result.Item2.ToString();

            result = vehicle.Move(2);
            submarineResult += result.Item1.ToString();
            submarineResult += result.Item2.ToString();

            result = vehicle.Move(4);
            submarineResult += result.Item1.ToString();
            submarineResult += result.Item2.ToString();

            result = vehicle.Move(6);
            submarineResult += result.Item1.ToString();
            submarineResult += result.Item2.ToString();

            vehicle.MoovementStrategy = new SubmarineUnderwaterMoovementStrategy();

            result = vehicle.Move(0);
            submarineResult += result.Item1.ToString();
            submarineResult += result.Item2.ToString();

            result = vehicle.Move(2);
            submarineResult += result.Item1.ToString();
            submarineResult += result.Item2.ToString();

            result = vehicle.Move(4);
            submarineResult += result.Item1.ToString();
            submarineResult += result.Item2.ToString();

            result = vehicle.Move(6);
            submarineResult += result.Item1.ToString();
            submarineResult += result.Item2.ToString();

            vehicle.MoovementStrategy = new SubmarineSurfaceMoovmentStrategy();

            result = vehicle.Move(0);
            submarineResult += result.Item1.ToString();
            submarineResult += result.Item2.ToString();

            result = vehicle.Move(2);
            submarineResult += result.Item1.ToString();
            submarineResult += result.Item2.ToString();

            result = vehicle.Move(4);
            submarineResult += result.Item1.ToString();
            submarineResult += result.Item2.ToString();

            result = vehicle.Move(6);
            submarineResult += result.Item1.ToString();
            submarineResult += result.Item2.ToString();

            string expectedSubmarine = "0-100-100-100-1001200-2-2000000000";

            Assert.AreEqual(expectedSubmarine, submarineResult);

            //Repülőgép teszt 
            vehicle.MoovementStrategy = new AirplaneAtmosphereMoovmentStrategy();
            string airplaneResult = "";

            result = vehicle.Move(0);
            airplaneResult += result.Item1.ToString();
            airplaneResult += result.Item2.ToString();

            result = vehicle.Move(2);
            airplaneResult += result.Item1.ToString();
            airplaneResult += result.Item2.ToString();

            result = vehicle.Move(4);
            airplaneResult += result.Item1.ToString();
            airplaneResult += result.Item2.ToString();

            result = vehicle.Move(6);
            airplaneResult += result.Item1.ToString();
            airplaneResult += result.Item2.ToString();

            vehicle.MoovementStrategy = new AirplaneUnderwaterMoovmentStrategy();
            result = vehicle.Move(0);
            airplaneResult += result.Item1.ToString();
            airplaneResult += result.Item2.ToString();

            result = vehicle.Move(2);
            airplaneResult += result.Item1.ToString();
            airplaneResult += result.Item2.ToString();

            result = vehicle.Move(4);
            airplaneResult += result.Item1.ToString();
            airplaneResult += result.Item2.ToString();

            result = vehicle.Move(6);
            airplaneResult += result.Item1.ToString();
            airplaneResult += result.Item2.ToString();

            vehicle.MoovementStrategy = new AirplaneSurfaceMoovmentStrategy();
            result = vehicle.Move(0);
            airplaneResult += result.Item1.ToString();
            airplaneResult += result.Item2.ToString();

            result = vehicle.Move(2);
            airplaneResult += result.Item1.ToString();
            airplaneResult += result.Item2.ToString();

            result = vehicle.Move(4);
            airplaneResult += result.Item1.ToString();
            airplaneResult += result.Item2.ToString();

            result = vehicle.Move(6);
            airplaneResult += result.Item1.ToString();
            airplaneResult += result.Item2.ToString();

            string expectedAirplane = "04500-7-500-20-20-20-2033000-30";

            Assert.AreEqual(expectedAirplane, airplaneResult);

            //Holdjáró teszt
            vehicle.MoovementStrategy = new RoverAtmosphereMoovmentStrategy();
            string roverResult = "";

            result = vehicle.Move(0);
            roverResult += result.Item1.ToString();
            roverResult += result.Item2.ToString();

            result = vehicle.Move(2);
            roverResult += result.Item1.ToString();
            roverResult += result.Item2.ToString();

            result = vehicle.Move(4);
            roverResult += result.Item1.ToString();
            roverResult += result.Item2.ToString();

            result = vehicle.Move(6);
            roverResult += result.Item1.ToString();
            roverResult += result.Item2.ToString();

            vehicle.MoovementStrategy = new RoverUnderwaterMoovmentStrategy();

            result = vehicle.Move(0);
            roverResult += result.Item1.ToString();
            roverResult += result.Item2.ToString();

            result = vehicle.Move(2);
            roverResult += result.Item1.ToString();
            roverResult += result.Item2.ToString();

            result = vehicle.Move(4);
            roverResult += result.Item1.ToString();
            roverResult += result.Item2.ToString();

            result = vehicle.Move(6);
            roverResult += result.Item1.ToString();
            roverResult += result.Item2.ToString();

            vehicle.MoovementStrategy = new RoverSurfaceMoovmentStrategy();

            result = vehicle.Move(0);
            roverResult += result.Item1.ToString();
            roverResult += result.Item2.ToString();

            result = vehicle.Move(2);
            roverResult += result.Item1.ToString();
            roverResult += result.Item2.ToString();

            result = vehicle.Move(4);
            roverResult += result.Item1.ToString();
            roverResult += result.Item2.ToString();

            result = vehicle.Move(6);
            roverResult += result.Item1.ToString();
            roverResult += result.Item2.ToString();

            string expectedRover = "0-100-100-100-100-20-20-20-2002000-20";

            Assert.AreEqual(expectedRover, roverResult);
            
            //Initial tests:

            //Vehicle vehicle;
            //int[] result;

            ////Repülőgép teszt
            //vehicle = new Vehicle("airplane");
            //string airplaneResult = "";

            //result = vehicle.Move("up", "atmosphere");
            //airplaneResult += result[0].ToString();
            //airplaneResult += result[1].ToString();

            //result = vehicle.Move("right", "atmosphere");
            //airplaneResult += result[0].ToString();
            //airplaneResult += result[1].ToString();

            //result = vehicle.Move("down", "atmosphere");
            //airplaneResult += result[0].ToString();
            //airplaneResult += result[1].ToString();

            //result = vehicle.Move("left", "atmosphere");
            //airplaneResult += result[0].ToString();
            //airplaneResult += result[1].ToString();

            //result = vehicle.Move("up", "underwater");
            //airplaneResult += result[0].ToString();
            //airplaneResult += result[1].ToString();

            //result = vehicle.Move("right", "underwater");
            //airplaneResult += result[0].ToString();
            //airplaneResult += result[1].ToString();

            //result = vehicle.Move("down", "underwater");
            //airplaneResult += result[0].ToString();
            //airplaneResult += result[1].ToString();

            //result = vehicle.Move("left", "underwater");
            //airplaneResult += result[0].ToString();
            //airplaneResult += result[1].ToString();

            //result = vehicle.Move("up", "surface");
            //airplaneResult += result[0].ToString();
            //airplaneResult += result[1].ToString();

            //result = vehicle.Move("right", "surface");
            //airplaneResult += result[0].ToString();
            //airplaneResult += result[1].ToString();

            //result = vehicle.Move("down", "surface");
            //airplaneResult += result[0].ToString();
            //airplaneResult += result[1].ToString();

            //result = vehicle.Move("left", "surface");
            //airplaneResult += result[0].ToString();
            //airplaneResult += result[1].ToString();

            //string expectedAirplane = "04500-7-500-20-20-20-2033000-30";

            //Assert.AreEqual(expectedAirplane, airplaneResult);

            ////Holdjáró teszt
            //vehicle = new Vehicle("rover");
            //string roverResult = "";

            //result = vehicle.Move("up", "atmosphere");
            //roverResult += result[0].ToString();
            //roverResult += result[1].ToString();

            //result = vehicle.Move("right", "atmosphere");
            //roverResult += result[0].ToString();
            //roverResult += result[1].ToString();

            //result = vehicle.Move("down", "atmosphere");
            //roverResult += result[0].ToString();
            //roverResult += result[1].ToString();

            //result = vehicle.Move("left", "atmosphere");
            //roverResult += result[0].ToString();
            //roverResult += result[1].ToString();

            //result = vehicle.Move("up", "underwater");
            //roverResult += result[0].ToString();
            //roverResult += result[1].ToString();

            //result = vehicle.Move("right", "underwater");
            //roverResult += result[0].ToString();
            //roverResult += result[1].ToString();

            //result = vehicle.Move("down", "underwater");
            //roverResult += result[0].ToString();
            //roverResult += result[1].ToString();

            //result = vehicle.Move("left", "underwater");
            //roverResult += result[0].ToString();
            //roverResult += result[1].ToString();

            //result = vehicle.Move("up", "surface");
            //roverResult += result[0].ToString();
            //roverResult += result[1].ToString();

            //result = vehicle.Move("right", "surface");
            //roverResult += result[0].ToString();
            //roverResult += result[1].ToString();

            //result = vehicle.Move("down", "surface");
            //roverResult += result[0].ToString();
            //roverResult += result[1].ToString();

            //result = vehicle.Move("left", "surface");
            //roverResult += result[0].ToString();
            //roverResult += result[1].ToString();

            //string expectedRover = "0-100-100-100-100-20-20-20-2002000-20";

            //Assert.AreEqual(expectedRover, roverResult);

            ////Tengeralattjáró teszt
            //vehicle = new Vehicle("submarine");
            //string submarineResult = "";

            //result = vehicle.Move("up", "atmosphere");
            //submarineResult += result[0].ToString();
            //submarineResult += result[1].ToString();

            //result = vehicle.Move("right", "atmosphere");
            //submarineResult += result[0].ToString();
            //submarineResult += result[1].ToString();

            //result = vehicle.Move("down", "atmosphere");
            //submarineResult += result[0].ToString();
            //submarineResult += result[1].ToString();

            //result = vehicle.Move("left", "atmosphere");
            //submarineResult += result[0].ToString();
            //submarineResult += result[1].ToString();

            //result = vehicle.Move("up", "underwater");
            //submarineResult += result[0].ToString();
            //submarineResult += result[1].ToString();

            //result = vehicle.Move("right", "underwater");
            //submarineResult += result[0].ToString();
            //submarineResult += result[1].ToString();

            //result = vehicle.Move("down", "underwater");
            //submarineResult += result[0].ToString();
            //submarineResult += result[1].ToString();

            //result = vehicle.Move("left", "underwater");
            //submarineResult += result[0].ToString();
            //submarineResult += result[1].ToString();

            //result = vehicle.Move("up", "surface");
            //submarineResult += result[0].ToString();
            //submarineResult += result[1].ToString();

            //result = vehicle.Move("right", "surface");
            //submarineResult += result[0].ToString();
            //submarineResult += result[1].ToString();

            //result = vehicle.Move("down", "surface");
            //submarineResult += result[0].ToString();
            //submarineResult += result[1].ToString();

            //result = vehicle.Move("left", "surface");
            //submarineResult += result[0].ToString();
            //submarineResult += result[1].ToString();

            //string expectedSubmarine = "0-100-100-100-1001200-2-2000000000";

            //Assert.AreEqual(expectedSubmarine, submarineResult);
        }
    }
}
