using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Player
    {
        public List<Card> Hand = new List<Card>();
        public int Points { get; set; }

        public Player(int points)
        {
            Points = points;
        }

        public void ChkBJ()
        {

        }
    }
}
