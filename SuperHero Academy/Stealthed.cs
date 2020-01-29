using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero_Academy
{
    class Stealthed : Hero
    {


        public Stealthed() // Konstruktor som låter spelaren bestämma namn, definierar dess kategori och slumpar stats och skriver ut dem med hjälp av GetStats() metoden. 
        {
            Name();

            category = Category(2);
            strength = generator.Next(0, 6);
            undetectability = generator.Next(5, 11);
            survivability = generator.Next(0, 3);

            GetStats();
        }
    }
}
