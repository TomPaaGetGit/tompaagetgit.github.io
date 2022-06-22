using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParreMedThomas
{
    internal class Plane : Vehicle, RunVehicle
    {
        public int Wingspan { get; set; }
        public int LoadCapacity { get; set; }
        public int Weight { get; set; }

        public Plane(int wingspan, int loadCapacity, int weight, string regNr, int effect) : base(regNr, effect)
        {
            Wingspan = wingspan;
            LoadCapacity = loadCapacity;
            Weight = weight;
        }

        public override void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine("DETTE ER ETT FLY");
            base.PrintInfo();
            Console.WriteLine(Wingspan);
            Console.WriteLine(LoadCapacity);
            Console.WriteLine(Weight);
        }

        public void Run()
        {
            Console.WriteLine();
            Console.WriteLine("Plane go brrrr");
        }
    }
}
