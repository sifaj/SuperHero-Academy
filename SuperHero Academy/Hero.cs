using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero_Academy
{
    class Hero
    {
        string name = "";
        protected string category = "";
        protected int strength = 0; // Tre olika stats: strenght, undetectability och survivability. Protected så de kan användas i sub-klasserna.
        protected int undetectability = 0;
        protected int survivability = 0;
        protected List<string> categories = new List<string>() { "Tank", "Ranged", "Stealthed" };

        protected Random generator = new Random(); // En random som fungerar som generator för att slumpa stats i sub-klasserna. 

        public void Name() // Låter spelaren bestämma sin hjältes namn.
        {
            Console.WriteLine("\nPlease enter your hero's name: ");
            name = Console.ReadLine();
        }

        public string Category(int listnumber) // Returnar input från listan categories beroende på vilken kategori spelaren har valt.
        {
            if (listnumber == 0)
            {
                return categories[0];
            }

            if (listnumber == 1)
            {
                return categories[1];
            }

            if (listnumber == 2)
            {
                return categories[2];
            }

            return "";
        }

        public virtual void GetStats() // En metod som skriver ut stats.
        {
            Console.WriteLine("\nSTATS: \nName: " + name + "\nCategory: " + category + "\nStrength: " + strength + "/10\nDetectability: " + undetectability + "/10\nSurvivability: " + survivability + "/10\n");
        }
    }
}
