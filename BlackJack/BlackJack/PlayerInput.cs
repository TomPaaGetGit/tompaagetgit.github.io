using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class PlayerInput
    {
        public string SInput { get; set; } = null!;

        public void StringInput()
        {
            SInput = Console.ReadLine()!.ToLower();
        }
    }
}
