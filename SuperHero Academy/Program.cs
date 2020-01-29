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
            input = Utils.Choice(1, 3);

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

        
    }
}
