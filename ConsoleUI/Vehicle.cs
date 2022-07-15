using System;
namespace ConsoleUI
{
    // Base class Vehicle
   public abstract class Vehicle
   {
        // Default Constructor
        public Vehicle()
        {

        }

        // Properties
        public string Make { get; set; } = "Default";
        public string Model { get; set; } = "Default";
        public int Year { get; set; } = 1900;


        // Methods
        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"{GetType().Name} is in drive.");
        }
   }
}

