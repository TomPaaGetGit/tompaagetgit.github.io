using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    internal class Pets : ShopItems
    {
        public string LetterText { get; set; }
        public Pets(string letterText, string name, int value, string description) : base(name, value, description)
        {
            LetterText = letterText;
        }

        public void ComposeLetter()
        {
            Console.WriteLine("Compose a letter and send it to a friend!");
            LetterText = Console.ReadLine();
            Console.WriteLine("The letter you wrote is as follows:");
            Console.WriteLine();
            Console.WriteLine(LetterText);
            Console.WriteLine();
            Console.WriteLine("Would you like to send it?");
        }
    }
}
