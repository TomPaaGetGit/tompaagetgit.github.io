using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abax_Oppgaven
{
    internal class Boat : VehicleWithSpeed
    {
        public int AvgWeight { get; set; }

        public Boat(int avgWeight, int topSpeed, string regNr, int power) : base(topSpeed, "Knop", regNr, power)
        {
            AvgWeight = avgWeight;
        }

        public override void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Båt");
            base.PrintInfo();
            Console.WriteLine($"Bruttotonnasje: {AvgWeight}");
        }

        public override void Run()
        {
            Console.WriteLine("Båt si brooom");
        }
    }
}
//Printe informasjon om en båt med kjennetegn ABC123, 100kw effekt, maksfart på 30knop, 500kg bruttotonnasje.