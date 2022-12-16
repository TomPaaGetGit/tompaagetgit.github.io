using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    internal class Game
    {
        public bool IsRunning { get; set; }
        public bool IsBattling { get; set; }
        public string OptionInput { get; set; }

        public Game(bool isRunning, bool isBattling, string optionInput)
        {
            IsRunning = isRunning;
            IsBattling = isBattling;
            OptionInput = optionInput;
        }
    }
}
