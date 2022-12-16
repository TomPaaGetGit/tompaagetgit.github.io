using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    internal class Shop
    {
        public List<Wand> WandsForSale = new List<Wand>();
        public List<Pets> PetsForSale = new List<Pets>();


        public void CreateLists()
        {
            PetsForSale.Add(new Pets("", "Owl", 1000, "A white feathered owl."));
            PetsForSale.Add(new Pets("", "Rat", 500, "A pet rat with a odd tail."));
            PetsForSale.Add(new Pets("", "Cat", 2000, "A black and white cat with a sassy attitude."));
            WandsForSale.Add(new Wand(30, "Phoenix Wand", 1000, "A wand with a phoenix feather core."));
            WandsForSale.Add(new Wand(40, "Unicorn Wand", 2000, "A wand with a unicorn hair core."));
            WandsForSale.Add(new Wand(40, "Troll Wand", 3000, "A wand with a troll whisker core."));
        }

        public void DisplayShop()
        {
            Console.Clear();
            Console.WriteLine("MAGICAL SHOP");
            Console.WriteLine();
            Console.WriteLine("Wands");
            foreach (var item in WandsForSale)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"Name: {item.Name}");
                Console.WriteLine($"Damage: {item.BaseDamage}");
                Console.WriteLine($"Cost: {item.Value}");
                Console.WriteLine($"Description: {item.Description}");

            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
            Console.WriteLine("Pets");
            foreach (var item in PetsForSale)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"Species: {item.Name}");
                Console.WriteLine($"Cost: {item.Value}");
                Console.WriteLine($"Description {item.Description}");
                
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("What would you like to buy?");

        }
    }
}
