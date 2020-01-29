using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero_Academy
{
    class Ranged : Hero
    {


        public Ranged() // Konstruktor som låter spelaren bestämma namn, definierar dess kategori och slumpar stats och skriver ut dem med hjälp av GetStats() metoden. 
        {
            Name();

            category = Category(1);
            strength = generator.Next(0, 3);
            undetectability = generator.Next(0, 6);
            survivability = generator.Next(5, 11);

            GetStats();
        }
    }
}
