using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParreMedThomas
{
    internal class JævliFæææst : Vehicle
    {
        public int MaxSpeed { get; set; }
        public string SpeedUnit { get; set; }

        public JævliFæææst(int maxSpeed, string speedUnit, string regNr, int effect) : base (regNr, effect)
        {
            MaxSpeed = maxSpeed;
            SpeedUnit = speedUnit;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"{MaxSpeed} {SpeedUnit}");
        }
    }
}
