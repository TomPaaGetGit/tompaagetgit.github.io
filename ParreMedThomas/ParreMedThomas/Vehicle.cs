using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParreMedThomas
{
    internal class Vehicle
    {
        public string RegNr { get; set; }
        public int Effect { get; set; }

        public Vehicle(string regNr, int effect)
        {
            RegNr = regNr;
            Effect = effect;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine(RegNr);
            Console.WriteLine(Effect);
        }
    }
}
