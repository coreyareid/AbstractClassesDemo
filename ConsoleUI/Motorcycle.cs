using System;
namespace ConsoleUI
{
    // Derived class Motorcycle
    public class Motorcycle : Vehicle
    {

        // Default Constructor
        public Motorcycle()
        {
        }

        // Properties
        public bool SportsBike { get; set; } = true;
        public bool Twoseater { get; set; } = false;

        // Methods
        public override void DriveAbstract()
        {
            Console.WriteLine($"{GetType().Name} is in drive.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Drive is virtual");
        }
    }
}

