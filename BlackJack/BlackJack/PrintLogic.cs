using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class PrintLogic
    {
        public void PrintPlayerDrawn(Player Player)
        {
            Console.WriteLine("Your main hand drew");
            foreach (var Card in Player.Hand)
            {
                Console.WriteLine($"{Card.CardName} of {Card.Suite}");
            }

            Console.Write($"Hand value: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{Player.Points}");
            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine();
            if (Player.IsSplit)
            {
                Console.WriteLine("Your split hand drew");
                foreach (var Card in Player.SplitHand)
                {
                    Console.WriteLine($"{Card.CardName} of {Card.Suite}");
                }

                Console.Write($"Split Hand value: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"{Player.SplitPoints}");
            }
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
        }

        public void PrintFirstDealerDrawn(Dealer Dealer)
        {
            Console.WriteLine("The dealer drew");
            Console.WriteLine($"{Dealer.Hand[0].CardName} of {Dealer.Hand[0].Suite}");
            Console.WriteLine("and a hidden card");
        }

        public void PrintDealerDrawn(Dealer Dealer)
        {
            Console.WriteLine("The dealer drew");
            foreach (var card in Dealer.Hand)
            {
                Console.WriteLine($"{card.CardName} of {card.Suite}");
            }

            Console.Write("Dealer value: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{Dealer.Points}");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
        }

        public void AskForInput(Player Player)
        {
            Console.WriteLine("What do you wish to do now?");
            Console.WriteLine("Hit");
            Console.WriteLine("Stand");
            if (Player.IsSplitAvailable != true) return;
            Console.WriteLine("Split");
        }

        public void PrintSplitWin(Player Player)
        {
            Console.WriteLine("Your split hand was worth: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{Player.SplitPoints}");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("YOUR SPLIT WON!!!");
            Console.ResetColor();
        }

        public void PrintSplitDraw(Player Player)
        {
            Console.WriteLine("Your split hand was worth: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{Player.SplitPoints}");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("YOUR SPLIT DRAW!");
            Console.ResetColor();
        }

        public void PrintSplitLoss(Player Player)
        {
            Console.WriteLine("Your split hand was worth: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{Player.SplitPoints}");
            Console.WriteLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("YOUR SPLIT LOST!");
            Console.ResetColor();
        }

        public void PrintGameWin(Player Player, Dealer Dealer)
        {
            Console.Clear();
            Console.WriteLine("Your main hand was worth: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{Player.Points}");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("The Dealer's Hand was worth: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"{Dealer.Points}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("YOU WON!!!");
            Console.ResetColor();
        }

        public void PrintGameDraw(Player Player, Dealer Dealer)
        {
            Console.Clear();
            Console.WriteLine("Your main hand was worth: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{Player.Points}");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("The Dealer's Hand was worth: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"{Dealer.Points}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("DRAW!");
            Console.ResetColor();
        }

        public void PrintGameLoss(Player Player, Dealer Dealer)
        {
            Console.Clear();
            Console.WriteLine("Your main hand was worth: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{Player.Points}");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("The Dealer's Hand was worth: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"{Dealer.Points}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("YOU LOST!");
            Console.ResetColor();
        }

        public void PrintPlayerBusted()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("MAIN HAND BUSTED!!!");
            Console.ResetColor();
        }

        public void PrintDealerBusted(Dealer Dealer)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("THE DEALER HAS BUSTED WITH ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{Dealer.Points} ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("POINTS.");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("YOU WIN!");
            Console.ResetColor();
        }
    }
}
