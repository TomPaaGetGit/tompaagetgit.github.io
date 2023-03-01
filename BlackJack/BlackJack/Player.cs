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
        public List<Card> SplitHand = new List<Card>();
        public int Points { get; set; }
        public int SplitPoints { get; set; }
        public bool IsSplit { get; set; }
        public bool IsSplitAvailable { get; set; }
        public bool IsBusted { get; set; }
        public bool IsSplitBusted { get; set; }

        public Player(int points, int splitPoints, bool isSplit, bool isSplitAvailable, bool isBusted, bool isSplitBusted)
        {
            Points = points;
            SplitPoints = splitPoints;
            IsSplit = isSplit;
            IsSplitAvailable = isSplitAvailable;
            IsBusted = isBusted;
            IsSplitBusted = isSplitBusted;
        }

        public void ChkSplit()
        {
            //Checks if the player has two cards with the same value and gives the option to split the hand into two
            //new hands.
            if (Hand[0].CardValue == Hand[1].CardValue)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("---------------");
                Console.WriteLine("SPLIT AVAILABLE");
                Console.WriteLine("---------------");
                Console.ResetColor();
                IsSplitAvailable = true;
            }
        }
        public void ChkAce()
        {
            //checks if the player has an ace in their hand after the first two cards are dealt.
            // Aces are worth either 1 or 11 points.
            if (Hand.Count == 1 && Hand[0].CardName.Contains("Ace") ||
                Hand[1].CardName.Contains("Ace"))
            {
                IsSplitAvailable = true;
                Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("ACE FOUND");
                Points += 10;
                Console.ResetColor();
            }
        }
        public void ChkBlkJk()
        {
            //checks if the points total is 21 after the first two cards are dealt.
            if (Points == 21 && Hand.Count == 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("BLACKJACK");
                Console.ResetColor();
            }
        }
        public void DoSplit()
        {
            IsSplit = true;
            SplitHand.Add(Hand[1]);
            Hand.Remove(Hand[1]);
        }
    }
}
