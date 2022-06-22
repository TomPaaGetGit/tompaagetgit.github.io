using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abax_Oppgaven
{
    abstract class Vehicle
    {
        public string RegNr { get; set; }
        public int Power { get; set; }

        protected Vehicle (string regNr, int power)
        {
            RegNr = regNr;
            Power = power;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"RegNr: {RegNr}");
            Console.WriteLine($"Kilowatt: {Power}");
        }

        public abstract void Run();
    }
}
//Konsollprogrammet skal be bil 1 om å kjøre og printe dette I konsollet
//Konsollprogrammet skal be flyet om å fly og printe dette i konsollet.