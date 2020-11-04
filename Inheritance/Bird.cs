using System;
namespace Inheritance
{
    // Create a class Bird
    // give this class 4 members that are specific to Bird
    // Set this class to inherit from your Animal Class

    public class Bird : Animal
    {
        public Bird()
        {
            IsAlive = true;
            LegCount = 2;
            LandSeaAir = "Air";
            Age = 0;
        }

        public string WingColor { get; set; }
        public bool CanFly { get; set; }
        public bool WillMigrate { get; set; }
        public double BeakLength { get; set; }

    }
}
