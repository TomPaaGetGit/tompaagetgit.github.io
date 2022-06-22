using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abax_Oppgaven
{
    internal class RoadVehicle : VehicleWithSpeed
    {
        public string Color { get; set; }
        public string TypeofCar { get; set; }

        public RoadVehicle(string color, string typeofCar, int topSpeed, string regNr, int power) 
            : base(topSpeed, "km/t", regNr, power)
        {
            Color = color;
            TypeofCar = typeofCar;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Bil");
            base.PrintInfo();
            Console.WriteLine($"Farge: {Color}");
            Console.WriteLine($"Type: {TypeofCar}");
        }

        public void CompareCars(RoadVehicle vehicle2)
        {
            Console.WriteLine();
            Console.WriteLine("Sammenligner biler...");
            if (Color == vehicle2.Color && TypeofCar == vehicle2.TypeofCar && TopSpeed == vehicle2.TopSpeed &&
                RegNr == vehicle2.RegNr && Power == vehicle2.Power)
            {
                Console.WriteLine();
                Console.WriteLine("Disse bilene er identiske.");
            }
            else if (Color == vehicle2.Color || TypeofCar == vehicle2.TypeofCar || TopSpeed == vehicle2.TopSpeed ||
                     RegNr == vehicle2.RegNr || Power == vehicle2.Power)
            {
                Console.WriteLine("Disse bilene har noe til felles men er ikke like.");
            }
            else { Console.WriteLine("Disse bilene er ikke like.");}
        }

        public override void Run()
        {
            Console.WriteLine();
            Console.WriteLine("Bilen Kjører nå");
        }
    }
}
//Printe informasjon om en en bil 1 med reg. nr NF123456, 147kw effekt, maksfart 200km/t, grønn farge av typen lett kjøretøy. 
//Printe informasjon om en annen bil (bil 2) med reg.nr NF654321, 150kw effekt, maksfart 195km/t, blå farge og av typen lett kjøretøy
//Sammenlikne de to bilene over for å sjekke om de er det samme kjøretøyet
