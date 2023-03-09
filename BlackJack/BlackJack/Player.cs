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
        public int Money { get; set; }
        public int CurrentBet { get; set; }
        public int SplitPoints { get; set; }
        public bool HasBlackjack { get; set; }
        public bool IsSplit { get; set; }
        public bool IsSplitAvailable { get; set; }
        public bool IsBusted { get; set; }
        public bool IsSplitBusted { get; set; }

        public Player(int points, int splitPoints, bool isSplit, bool isSplitAvailable, bool isBusted, bool isSplitBusted, bool hasBlackjack, int money, int currentBet)
        {
            Points = points;
            SplitPoints = splitPoints;
            IsSplit = isSplit;
            IsSplitAvailable = isSplitAvailable;
            IsBusted = isBusted;
            IsSplitBusted = isSplitBusted;
            HasBlackjack = hasBlackjack;
            Money = money;
            CurrentBet = currentBet;
        }

        public void ChkSplit()
        {
            //Checks if the player has two cards with the same value and gives the option to split the hand into two
            //new hands.
            if (Hand[0].CardValue == Hand[1].CardValue)
            {
                IsSplitAvailable = true;
            }
        }

        public void PlayerCheckBlackJack(Player Player)
        {
            if (Player.Points == 21)
            {
                Player.HasBlackjack = true;
            }
        }
        public void ChkAce()
        {
            //checks if the player has an ace in their hand after the first two cards are dealt.
            // Aces are worth either 1 or 11 points.
            if (Hand.Count == 1 && Hand[0].CardName.Contains("Ace") ||
                Hand[1].CardName.Contains("Ace"))
            {
                Points += 10;
            }
        }
        public void DoSplit()
        {
            if (IsSplit != true)
            {
                IsSplit = true;
                SplitHand.Add(Hand[1]);
                SplitPoints = SplitHand[0].CardValue;
                Points -= Hand[1].CardValue;
                Hand.Remove(Hand[1]);
            }
        }
    }
}
