using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            Console.WriteLine("Welcome to SuperHero Academy!");
            
            Hero h1;

            Console.WriteLine("Please choose a hero-category: 1. Tank  2. Ranged  3. Stealthed");
            input = Choice(1, 3);

            if (input == 1)
            {
                h1 = new Tank();
            }
            
            if (input == 2)
            {
                h1 = new Stealthed();
            }
            
            if (input == 3)
            {
                h1 = new Ranged();
            }



            Console.ReadLine();
            
        }

        public static int Choice(int minChoice, int maxChoice) // En metod som möjliggör att välja hur många inputs spelaren kan ge, och som ser till att den är giltig inom angett scope.
        {
            int returnValue = 0;
            bool check = false;
            Console.WriteLine("Choose a number between " + minChoice + " and " + maxChoice + " as input.");

            while (check == false)
            {
                int.TryParse(Console.ReadLine(), out returnValue);

                if (returnValue > maxChoice || returnValue < minChoice)
                {
                    Console.WriteLine("Not compliable. Choose a number between " + minChoice + " and " + maxChoice + " as input.");
                    check = false;
                }
                else
                {
                    return returnValue;
                }
            }

            return 1;
        }
    }
}
