using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    internal class NonPlayerCharacter : Character
    {
        public NonPlayerCharacter(string name, int health, int damage) : base(name, health, damage)
        {

        }


    }
}
