using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Deck
    {
        public List<Card> DeckofCards = new List<Card>();

        public void CreateDeck()
        {
            DeckofCards.Add(new Card("Spades", "Ace", 1));
            DeckofCards.Add(new Card("Spades", "Two", 2));
            DeckofCards.Add(new Card("Spades", "Three", 3));
            DeckofCards.Add(new Card("Spades", "Four", 4));
            DeckofCards.Add(new Card("Spades", "Five", 5));
            DeckofCards.Add(new Card("Spades", "Six", 6));
            DeckofCards.Add(new Card("Spades", "Seven", 7));
            DeckofCards.Add(new Card("Spades", "Eight", 8));
            DeckofCards.Add(new Card("Spades", "Nine", 9));
            DeckofCards.Add(new Card("Spades", "Ten", 10));
            DeckofCards.Add(new Card("Spades", "Jack", 10));
            DeckofCards.Add(new Card("Spades", "Queen", 10));
            DeckofCards.Add(new Card("Spades", "King", 10));
            
            DeckofCards.Add(new Card("Hearts", "Ace", 1));
            DeckofCards.Add(new Card("Hearts", "Two", 2));
            DeckofCards.Add(new Card("Hearts", "Three", 3));
            DeckofCards.Add(new Card("Hearts", "Four", 4));
            DeckofCards.Add(new Card("Hearts", "Five", 5));
            DeckofCards.Add(new Card("Hearts", "Six", 6));
            DeckofCards.Add(new Card("Hearts", "Seven", 7));
            DeckofCards.Add(new Card("Hearts", "Eight", 8));
            DeckofCards.Add(new Card("Hearts", "Nine", 9));
            DeckofCards.Add(new Card("Hearts", "Ten", 10));
            DeckofCards.Add(new Card("Hearts", "Jack", 10));
            DeckofCards.Add(new Card("Hearts", "Queen", 10));
            DeckofCards.Add(new Card("Hearts", "King", 10));

            DeckofCards.Add(new Card("Clubs", "Ace", 1));
            DeckofCards.Add(new Card("Clubs", "Two", 2));
            DeckofCards.Add(new Card("Clubs", "Three", 3));
            DeckofCards.Add(new Card("Clubs", "Four", 4));
            DeckofCards.Add(new Card("Clubs", "Five", 5));
            DeckofCards.Add(new Card("Clubs", "Six", 6));
            DeckofCards.Add(new Card("Clubs", "Seven", 7));
            DeckofCards.Add(new Card("Clubs", "Eight", 8));
            DeckofCards.Add(new Card("Clubs", "Nine", 9));
            DeckofCards.Add(new Card("Clubs", "Ten", 10));
            DeckofCards.Add(new Card("Clubs", "Jack", 10));
            DeckofCards.Add(new Card("Clubs", "Queen", 10));
            DeckofCards.Add(new Card("Clubs", "King", 10));

            DeckofCards.Add(new Card("Diamonds", "Ace", 1));
            DeckofCards.Add(new Card("Diamonds", "Two", 2));
            DeckofCards.Add(new Card("Diamonds", "Three", 3));
            DeckofCards.Add(new Card("Diamonds", "Four", 4));
            DeckofCards.Add(new Card("Diamonds", "Five", 5));
            DeckofCards.Add(new Card("Diamonds", "Six", 6));
            DeckofCards.Add(new Card("Diamonds", "Seven", 7));
            DeckofCards.Add(new Card("Diamonds", "Eight", 8));
            DeckofCards.Add(new Card("Diamonds", "Nine", 9));
            DeckofCards.Add(new Card("Diamonds", "Ten", 10));
            DeckofCards.Add(new Card("Diamonds", "Jack", 10));
            DeckofCards.Add(new Card("Diamonds", "Queen", 10));
            DeckofCards.Add(new Card("Diamonds", "King", 10));
        }
    }
}
