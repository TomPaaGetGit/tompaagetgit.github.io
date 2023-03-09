using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Table
    {
        public bool IsRunning = false;
        Dealer Dealer = new Dealer(0, false, false);
        Player Player = new Player(0, 0, false, false, false, false, false, 1000, 0);
        PrintLogic Print = new PrintLogic();
        PlayerInput Input = new PlayerInput();
        public void Game()
        {
            TakeBets();
            StartGame();

            while (IsRunning)
            {
                Print.AskForGameInput(Player);
                Input.StringInput();
                HandleGameInput();
            }
        }

        public void PrintInfo()
        {
            Console.Clear();
            Print.PrintPlayerBet(Player);
            Print.PrintPlayerDrawn(Player);
            Print.PrintDealerDrawn(Dealer);
        }

        public void TakeBets()
        {
            Print.AskForBetInput(Player);
            Input.NumberInput();
            HandleBetInput();
        }
        public void StartGame()
        {
            IsRunning = true;
            Dealer.InitDealer();

            Dealer.DealToPlayer(Player);
            Dealer.DealToPlayer(Player);
            Dealer.DealToDealer(Dealer);
            Dealer.DealToDealer(Dealer);

            Player.ChkSplit();
            Player.ChkAce();
            Dealer.ChkAce();

            Dealer.DealerCheckBlackJack(Dealer);
            Player.PlayerCheckBlackJack(Player);

            HandleBlackJack();
        }

        public void HandleBlackJack()
        {
            if (Dealer.HasBlackjack && Player.HasBlackjack)
            {
                Console.Clear();
                Print.PrintPlayerDrawn(Player);
                Print.PrintDealerDrawn(Dealer);
                Print.PrintBothBlackJack();
                IsRunning = false;
            }

            if (Player.HasBlackjack && IsRunning)
            {
                Console.Clear();
                Print.PrintPlayerDrawn(Player);
                Print.PrintDealerDrawn(Dealer);
                Print.PrintPlayerBlackJack();
                IsRunning = false;

            }
            else if (Dealer.HasBlackjack && IsRunning)
            {
                Console.Clear();
                Print.PrintPlayerDrawn(Player);
                Print.PrintDealerDrawn(Dealer);
                Print.PrintDealerBlackJack();
                IsRunning = false;
            }
            else
            {
                PrintInfo();
            }
        }

        public void HandleBetInput()
        {
            if (Input.NInput > Player.Money)
            {
                Console.WriteLine("Broke bitch.");
                TakeBets();
            }
            else
            {
                Player.CurrentBet = Input.NInput;
            }
        }
        public void HandleGameInput()
        {
            if (Input.SInput == "e" || Input.SInput == "")
            {
                IsRunning = false;
            }
            if (Input.SInput == "hit")
            {
                Console.Clear();
                Dealer.DealToPlayer(Player);
                CheckBusted();
                PrintInfo();
            }

            if (Input.SInput == "split")
            {
                Console.Clear();
                Player.DoSplit();
                PrintInfo();
            }
            if (Input.SInput == "stand")
            {
                Dealer.DealerPlays(Dealer);
                if (Dealer.IsBusted)
                {
                    Console.Clear();
                    Print.PrintPlayerDrawn(Player);
                    Print.PrintDealerDrawn(Dealer);
                    Print.PrintDealerBusted(Dealer);
                }
                else
                {
                    CheckWinners();
                }
                IsRunning = false;
            }
        }

        public void CheckBusted()
        {
            if (Player.IsBusted)
            {
                Print.PrintPlayerBusted();
                IsRunning = false;
            }
        }
        public void CheckWinners()
        {
            if (Player.Points > Dealer.Points)
            {
                Print.PrintGameWin(Player, Dealer);
                if (Player.IsSplit)
                {
                    CheckSplitWin();
                }
            }
            else if (Player.Points == Dealer.Points)
            {
                Print.PrintGameDraw(Player, Dealer);
                if (Player.IsSplit)
                {
                    CheckSplitWin();
                }
                
            }
            else
            {
                Print.PrintGameLoss(Player, Dealer);
                if (Player.IsSplit)
                {
                    CheckSplitWin();
                }
                
            }
        }
        public void CheckSplitWin()
        {
            if (Player.SplitPoints > Dealer.Points)
            {
                Print.PrintSplitWin(Player);
            }
            else if (Player.SplitPoints == Dealer.Points)
            {
                Print.PrintSplitDraw(Player);

            }
            else
            {
                Print.PrintSplitLoss(Player);
            }
        }
    }
}
