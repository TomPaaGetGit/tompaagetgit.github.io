using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Card
    {
        public string Suite { get; }
        public string CardName { get; }
        public int CardValue { get; }

        public Card(string suite, string cardName, int cardValue)
        {
            Suite = suite;
            CardName = cardName;
            CardValue = cardValue;
        }
    }
}
