using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero_Academy
{
    class Tank : Hero
    {


        public Tank() // Konstruktor som slumpar stats och skriver ut dem med hjälp av GetStats() metoden. 
        {
            Name();

            category = categories[0];
            strength = generator.Next(5, 11);
            undetectability = generator.Next(0, 3);
            survivability = generator.Next(0, 6);

            GetStats();
        }

    }
}
