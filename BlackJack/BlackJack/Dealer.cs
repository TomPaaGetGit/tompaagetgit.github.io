using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{

    internal class Dealer
    {
        public List<Card> Hand = new List<Card>();
        public int Points { get; set; }
        public Deck Deck = new Deck();
        public RndNum Rnd = new RndNum(53);
        public bool IsBusted { get; set;}
        public bool HasBlackjack { get; set;}

        public Dealer(int points, bool isBusted, bool hasBlackjack)
        {
            Points = points;
            IsBusted = isBusted;
            HasBlackjack = hasBlackjack;
        }

        public void InitDealer()
        {
            Deck.CreateDeck();
        }
        public void DealToDealer(Dealer Dealer)
        {
            var num = Rnd.RandomNumber();
            Dealer.Hand.Add(Deck.DeckofCards[num]);
            Dealer.Points += Deck.DeckofCards[num].CardValue;
            Deck.DeckofCards.Remove(Deck.DeckofCards[num]);
            Rnd.Size = Deck.DeckofCards.Count;
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
        public void ChkBlkJk()
        {
            //checks if the points total is 21 after the first two cards are dealt.
            if (Points == 21 && Hand.Count == 1)
            {
                HasBlackjack = true;
            }
        }

        public void DealerPlays(Dealer Dealer)
        {
            while (Dealer.Points < 17)
            {
                var num = Rnd.RandomNumber();
                Dealer.Hand.Add(Deck.DeckofCards[num]);
                Dealer.Points += Deck.DeckofCards[num].CardValue;
                Deck.DeckofCards.Remove(Deck.DeckofCards[num]);
                Rnd.Size = Deck.DeckofCards.Count;
                if (Dealer.Points > 21)
                {
                    Dealer.IsBusted = true;
                }
            }
        }
        public void DealToPlayer(Player Player)
        {
            if (Player.IsBusted == true) return;
            var num = Rnd.RandomNumber();
            Player.Hand.Add(Deck.DeckofCards[num]);
            Player.Points += Deck.DeckofCards[num].CardValue;
            Deck.DeckofCards.Remove(Deck.DeckofCards[num]);
            Rnd.Size = Deck.DeckofCards.Count;
            if (Player.Points > 21)
            {
                Player.IsBusted = true;
            }

            if (Player.IsSplit != true || Player.IsSplitBusted == true) return;
            var num2 = Rnd.RandomNumber();
            Player.SplitHand.Add(Deck.DeckofCards[num2]);
            Player.SplitPoints += Deck.DeckofCards[num2].CardValue;
            Deck.DeckofCards.Remove(Deck.DeckofCards[num2]);
            Rnd.Size = Deck.DeckofCards.Count;
            if (Player.SplitPoints > 21)
            {
                Player.IsSplitBusted = true;
            }
        }
    }
}
