﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Table
    {
        public bool IsRunning = true;
        Dealer Dealer = new Dealer(0, false, false);
        Player Player = new Player(0, 0, false, false, false, false, false);
        PrintLogic Print = new PrintLogic();
        PlayerInput Input = new PlayerInput();
        public void Game()
        {
            StartGame();

            while (IsRunning)
            {
                Print.AskForInput(Player);
                Input.StringInput();
                HandleInput();
            }
        }

        public void PrintInfo()
        {
            Print.PrintPlayerDrawn(Player);
            Print.PrintDealerDrawn(Dealer);
        }

        public void StartGame()
        {
            Dealer.InitDealer();

            Dealer.DealToPlayer(Player);
            Dealer.DealToPlayer(Player);
            Dealer.DealToDealer(Dealer);
            Dealer.DealToDealer(Dealer);

            Player.ChkSplit();
            Player.ChkAce();
            Player.ChkBlkJk();
            Dealer.ChkAce();
            Dealer.ChkBlkJk();
            if (Player.HasBlackjack || Dealer.HasBlackjack)
            {
                HandleBlackJack();
            }

            Print.PrintPlayerDrawn(Player);
            Print.PrintDealerDrawn(Dealer);
        }

        public void HandleBlackJack()
        {
            if (Player.HasBlackjack)
            {
                Print.PrintPlayerBlackJack();

            }
            else if (Dealer.HasBlackjack)
            {
                Console.WriteLine("Impliment me :)");
            }
            else if (Dealer.HasBlackjack && Player.HasBlackjack)
            {
                Console.WriteLine("We both had it???");
            }
        }
        public void HandleInput()
        {
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
