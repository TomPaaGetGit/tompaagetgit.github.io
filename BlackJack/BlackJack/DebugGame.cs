using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class DebugGame
    {
        public void TestDebug()
        {
            var rnd = new RndNum();
            var puss = new Player(0);
            var dick = new Deck();
            dick.CreateDeck();

            void DrawCard()
            {
                var num = rnd.RandomNumber();
                puss.Hand.Add(dick.DeckofCards[num]);
                dick.DeckofCards.Remove(dick.DeckofCards[num]);
            }

            void PrintCards()
            {
                int DeckSize = 0;
                Console.WriteLine("You drew");
                foreach (var card in puss.Hand)
                {
                    Console.WriteLine($"{card.CardName} of {card.Suite}");
                }

                foreach (var card in dick.DeckofCards)
                {
                    DeckSize += 1;
                }

                foreach (var card in puss.Hand)
                {
                    puss.Points += card.CardValue;
                }

                Console.WriteLine($"Your hand is worth {puss.Points} points.");
                Console.WriteLine($"There are {DeckSize} cards left in the deck.");
            }
            DrawCard();
            DrawCard();
            PrintCards();


        }
    }
}
