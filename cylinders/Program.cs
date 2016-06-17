using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cylinders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter to start.");
            
            string userInput = Console.ReadLine();

            while (userInput != "no")
            {
                Console.WriteLine("Let's examine cylinders.");
                Console.WriteLine("What is radius?");
                // Console.ReadLine() gives a string, but we want a double
                // so convert it
                double radius = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("What is height?");
                double height = Convert.ToDouble(Console.ReadLine());

                double pi = 3.14159;

                if (radius > 0 && height > 0)
                {
                    // Volume: radius^2 * height* pi
                    // we're doing radius * radius to mean radius^2
                    double volume = (radius * radius) * height * pi;
                    Console.WriteLine("The volume is " + volume);

                    // Surface area: 2pi r * height + 2pi r^2
                    double surfaceArea = (2 * pi * radius * height) + (2 * pi * radius * radius);
                    Console.WriteLine("The surface area is " + surfaceArea);

                }
                else
                {
                    Console.WriteLine("Height and radius must not be negative!");
                }

                Console.WriteLine("Thanks for playing!");

                Console.WriteLine("Would you like to play again?");
                userInput = Console.ReadLine();
                

            }    
                    
               Console.WriteLine("Thank you for playing.");
                     

            Console.ReadKey();
        }
    }
}