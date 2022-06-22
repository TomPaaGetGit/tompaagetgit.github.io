using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ParreMedThomas
{
    internal class Boat : JævliFæææst
    {
        public int GrossWeight { get; set; }

        public Boat(int grossWeight, int maxSpeed, string regNr, int effect) 
            : base (maxSpeed, "knop", regNr, effect)
        {
            GrossWeight = grossWeight;
        }

        public override void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine("DETTE ER EN BÅT");
            base.PrintInfo();
            Console.WriteLine(GrossWeight);
        }
    }
}
