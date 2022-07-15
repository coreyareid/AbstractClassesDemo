using System;
namespace ConsoleUI
{
    // Derived class Car
    public class Car : Vehicle
    {

        // Default Constructor
        public Car()
        {
        }

        // Propterties
        public bool HasTrunk { get; set; } = true;
        public string AmountOfDoors { get; set; } = "4 Door";


        //Methods
        public override void DriveAbstract()
        {
            Console.WriteLine($"{GetType().Name} is in drive.");
        }

    }
}

