using System;
namespace Inheritance
{
    // Create a class Animal
    // give this class 4 members that all Animals have in common

    public class Animal
    {
        public Animal()
        {
        }

        public bool IsAlive { get; set; }
        public int Age { get; set; }
        public int LegCount { get; set; }
        public string LandSeaAir { get; set; }


    }
}
