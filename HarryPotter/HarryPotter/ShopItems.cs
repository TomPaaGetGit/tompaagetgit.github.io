using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    internal class ShopItems
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }

        public ShopItems(string name, int value, string description)
        {
            Name = name;
            Value = value;
            Description = description;
        }
    }
}
