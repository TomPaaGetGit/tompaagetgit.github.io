using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    internal class Wand : ShopItems
    {
        public int BaseDamage;

        public Wand(int baseDamage, string name, int value, string description) 
            : base(name, value, description)
        {
            BaseDamage = baseDamage;
        }

    }
}
