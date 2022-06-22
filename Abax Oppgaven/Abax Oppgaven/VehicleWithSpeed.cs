using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abax_Oppgaven
{
    abstract class VehicleWithSpeed : Vehicle
    {
        public int TopSpeed { get; set; }
        public string SpeedUnit { get; set; }

        protected VehicleWithSpeed(int topSpeed, string speedUnit, string regNr, int power) : base(regNr, power)
        {
            TopSpeed = topSpeed;
            SpeedUnit = speedUnit;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Toppfart: {TopSpeed}{SpeedUnit}");
        }
    }
}
