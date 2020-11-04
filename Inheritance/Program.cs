using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var aBird = new Bird();
            aBird.WingColor = "blue";
            aBird.CanFly = true;
            aBird.WillMigrate = true;
            aBird.BeakLength = 3.5;


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var aReptile = new Reptile()
            {
                IsColdBlooded = true,
                IsScaly = true,
                Habitat = "swamp",
                CanGrowTail = true
            };

            var zoo = new Animal[] { aBird, aReptile };

            foreach (var animal in zoo)
            {
                Console.WriteLine($"Alive? {animal.IsAlive}");
                Console.WriteLine($"Age: {animal.Age}");
                Console.WriteLine($"Leg Count: {animal.LegCount}");
                Console.WriteLine($"Lives in {animal.LandSeaAir}");
                Console.WriteLine();
            }

            Console.WriteLine("Specifically for the bird:");
            Console.WriteLine($"A {aBird.WingColor} wing color");
            Console.WriteLine($"Can it fly? {aBird.CanFly}");
            Console.WriteLine($"Will it migrate? {aBird.WillMigrate}");
            Console.WriteLine($"How long is its beak? {aBird.BeakLength}");
            Console.WriteLine();

            Console.WriteLine("And for the reptilian creature:");
            Console.WriteLine($"Cold blooded? {aReptile.IsColdBlooded}");
            Console.WriteLine($"And scaly? {aReptile.IsScaly}");
            Console.WriteLine($"Where does it inhabit? {aReptile.Habitat}");
            Console.WriteLine($"Can it grow a tail back? {aReptile.CanGrowTail}");

        }
    }
}
