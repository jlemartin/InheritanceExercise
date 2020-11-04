using System;
namespace Inheritance
{
    // Create a class Reptile
    // give this class 4 members that are specific to Reptile
    // Set this class to inherit from your Animal Class

    public class Reptile : Animal
    {
        public Reptile()
        {
            IsAlive = true;
            LegCount = 4;
            LandSeaAir = "Land";
            Age = 0;
        }

        public bool IsColdBlooded { get; set; }
        public bool IsScaly { get; set; }
        public string Habitat { get; set; }
        public bool CanGrowTail { get; set; }


    }
}
