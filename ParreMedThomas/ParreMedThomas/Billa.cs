using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParreMedThomas
{
    internal class Billa : JævliFæææst, RunVehicle
    {
        public string Color { get; set; }
        public string CarType { get; set; }

        public Billa(string color, string carType, int maxSpeed, string regNr, int effect) 
            : base (maxSpeed, "Km/t", regNr, effect)
        {
            Color = color;
            CarType = carType;
        }

        public override void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine("DETTE ER EN BIL");
            base.PrintInfo();
            Console.WriteLine(Color);
            Console.WriteLine(CarType);
        }

        public void CompareCars(Billa car2)
        {
            Console.WriteLine();
            Console.WriteLine("Sammenligner biler...");
            if (Color == car2.Color && CarType == car2.CarType && MaxSpeed == car2.MaxSpeed &&
                RegNr == car2.RegNr && Effect == car2.Effect)
            {
                Console.WriteLine();
                Console.WriteLine("Disse bilene er identiske.");
            }
            else if (Color == car2.Color || CarType == car2.CarType || MaxSpeed == car2.MaxSpeed ||
                     RegNr == car2.RegNr || Effect == car2.Effect)
            {
                Console.WriteLine("Disse bilene har noe til felles men er ikke like.");
            }
            else { Console.WriteLine("Disse bilene er ikke like."); }
        }

        public void Run()
        {
            Console.WriteLine();
            Console.WriteLine("Bilen sier brom");
        }
    }
}
