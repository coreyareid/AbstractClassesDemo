using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Vehicles

            // List
            List<Vehicle> vehicleList = new List<Vehicle>();


            // Instance 1
            Car honda = new Car()
            {
                Make = "Honda",
                Model = "Civic",
                Year = 2019,
                HasTrunk = true,
                AmountOfDoors = " 4 Door"
            };

            // Instance 2
            Motorcycle indian = new Motorcycle()
            {
                Make = "Indian",
                Model = "Monster 699",
                Year = 2014,
                SportsBike = true,
                Twoseater = false
            };

            // Instance 3
            Vehicle truck = new Car()
            {
                Make = "Chevy",
                Model = " 4 X 4",
                Year = 2003,
                HasTrunk = false,
                AmountOfDoors = "2 DOOR"
            };

            // Instance 4
            Vehicle fourWheeler = new Car()
            {
                Make = "Honda",
                Model = "N/A",
                Year = 2022,
                HasTrunk = false,
                AmountOfDoors = "None"
            };


            // Adds Instances to list
            vehicleList.Add(honda);
            vehicleList.Add(indian);
            vehicleList.Add(truck);
            vehicleList.Add(fourWheeler);


            // foreach loop which list information of the instances
            Console.WriteLine("--------------------------------------------");
            foreach (var instance in vehicleList)
            {
                Console.WriteLine($"Make: {instance.Make}, Model: {instance.Model}, Year: {instance.Year}.");
                instance.DriveAbstract();
            }
            Console.WriteLine("--------------------------------------------");

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
