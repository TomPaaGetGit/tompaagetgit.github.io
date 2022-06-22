using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abax_Oppgaven
{
    internal class Plane : Vehicle
    {
        public int Wingspan { get; set; }
        public int Capacity { get; set; }
        public int Weight { get; set; }
        public string SizeClass { get; set; }

        public Plane(int wingspan, int capacity, int weight, string sizeClass, string regNr, int power) : base(regNr, power)
        {
            Wingspan = wingspan;
            Capacity = capacity;
            Weight = weight;
            SizeClass = sizeClass;
        }

        public override void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Fly");
            base.PrintInfo();
            Console.WriteLine($"Vingespenn: {Wingspan}m");
            Console.WriteLine($"Lasteevne: {Capacity} tonn");
            Console.WriteLine($"Egenvekt: {Weight} tonn");
            Console.WriteLine($"Type: {SizeClass}");
        }

        public override void Run()
        {
            Console.WriteLine();
            Console.WriteLine("Flyet flyr!");
        }
    }
}
//Printe informasjon om et fly med kjennetegn LN1234, 1000kw effekt, 30m vingespenn, 2tonn lasteevne, 10 tonn egenvekt I flyklasse jetfly
