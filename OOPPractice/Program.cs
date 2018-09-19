using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dog woofie = new Dog();
            //Dog spot = new Dog();

            //Dog woofie = new Dog(7, 8.5, 33.2, 190.1, "Woofie");
            //Dog spot = new Dog(15, 10.0, 100.9, 250.3, "Spot");

            //Console.WriteLine("Woofie's hair length is: {0}", woofie.HairLength);
            //Console.WriteLine("Spot's hair length is: {0}", spot.HairLength);

            //woofie.HairLength = 4;
            //spot.HairLength = 6;

            //woofie.GetSpeed(7);
            //spot.GetSpeed(11);

            //Console.WriteLine("Woofie's hair length is: {0}", woofie.HairLength);
            //Console.WriteLine("Spot's hair length is: {0}", spot.HairLength);

            //Console.WriteLine("Woofie is running {0}", woofie.GetSpeed(7));

            SuperHero kayti = new SuperHero(50, true, "psychic", "vampires");
            Console.WriteLine("Do you want to increase your strength?");
            if (Console.ReadLine() == "yes")
            {
                kayti.GetHealth(100);                
            }
        }
    }
}
