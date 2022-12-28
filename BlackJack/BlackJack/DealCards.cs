using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class DealCards
    {
        public void InitDeal()
        {
            var Num = new RndNum();
            var Deck = new Deck();
            var player = new Player(0);
            var dealer = new Player(0);
            Deck.CreateDeck();

            void Deal()
            {

            }

        }
    }
}
