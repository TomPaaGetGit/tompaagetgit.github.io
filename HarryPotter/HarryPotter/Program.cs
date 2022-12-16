using System;

namespace HarryPotter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shoppingcentre = new Shop();
            var voldemort = new NonPlayerCharacter("Voldemort", 100, 10);
            var player = new PlayerCharacter(null, null, "Gryffindoor", 1000, "Harry Potter", 50, 1);
            var gameState = new Game(true, true, "");

            shoppingcentre.CreateLists();
            while (gameState.IsRunning)
            {
                Menu();
            }
            void Menu()
            {
                Console.Clear();
                Console.WriteLine("Welcome to the HarryPotter Task!");
                Console.WriteLine("Main Menu");
                Console.WriteLine($"Stats: Money: {player.Money} Coins   Health: {player.Health}   House: {player.House}   Damage:{player.Damage}");
                Console.WriteLine("Please enter an option.");
                Console.WriteLine("1. Introduce myself again.");
                Console.WriteLine("2. Cast a spell.");
                Console.WriteLine("3. Go shopping.");
                Console.WriteLine("4. Go to battle.");
                Console.WriteLine("5. Send mail to a friend.");
                Console.WriteLine("6. Exit.");
                gameState.OptionInput = Console.ReadLine().ToLower();
                if (gameState.OptionInput is "1") { player.Introduce(); }
                else if (gameState.OptionInput is "2") { player.SpellCast(); }
                else if (gameState.OptionInput is "3") { shoppingcentre.DisplayShop(); ShoppingMenu(); }
                else if (gameState.OptionInput is "4") { Console.Clear(); Battle();}
                else if (gameState.OptionInput is "5") { Console.Clear();
                    if (player.Pet is null)
                    {
                        Console.WriteLine("I don't have a pet yet, I need to buy one!");
                    } else { player.Pet.ComposeLetter();}
                }
                else if (gameState.OptionInput is "6") { Console.Clear(); Console.WriteLine("Closing!"); gameState.IsRunning = false; }
            }

            void ShoppingMenu()
            {
                gameState.OptionInput = Console.ReadLine().ToLower();
                if (gameState.OptionInput is "phoenix wand" or "1") {
                    if (player.Money < shoppingcentre.WandsForSale[0].Value)
                    {
                        Console.Clear();
                        Console.WriteLine("You don't have enough money for this yet!");
                        Console.ReadLine();
                    } else
                    {
                        player.Money -= shoppingcentre.WandsForSale[0].Value;
                        Console.WriteLine($"Bought {shoppingcentre.WandsForSale[0].Name}!");
                        player.CurrentWand = shoppingcentre.WandsForSale[0];
                        Console.ReadLine();
                    }

                }
                else if (gameState.OptionInput is "unicorn wand" or "2") {
                    if (player.Money < shoppingcentre.WandsForSale[1].Value)
                    {
                        Console.Clear();
                        Console.WriteLine("You don't have enough money for this yet!");
                        Console.ReadLine();
                    }
                    else
                    {
                        player.Money -= shoppingcentre.WandsForSale[1].Value;
                        Console.WriteLine($"Bought {shoppingcentre.WandsForSale[1].Name}!");
                        player.CurrentWand = shoppingcentre.WandsForSale[1];
                        Console.ReadLine();
                    }

                }
                else if (gameState.OptionInput is "troll wand" or "3")
                {
                    if (player.Money < shoppingcentre.WandsForSale[2].Value)
                    {
                        Console.Clear();
                        Console.WriteLine("You don't have enough money for this yet!");
                        Console.ReadLine();
                    }
                    else
                    {
                        player.Money -= shoppingcentre.WandsForSale[2].Value;
                        Console.WriteLine($"Bought {shoppingcentre.WandsForSale[2].Name}!");
                        player.CurrentWand = shoppingcentre.WandsForSale[2];
                        Console.ReadLine();
                    }

                }
                else if (gameState.OptionInput is "pet owl" or "4")
                {
                    if (player.Money < shoppingcentre.PetsForSale[0].Value)
                    {
                        Console.Clear();
                        Console.WriteLine("You don't have enough money for this yet!");
                        Console.ReadLine();
                    }
                    else
                    {
                        player.Money -= shoppingcentre.PetsForSale[0].Value;
                        Console.WriteLine($"Bought {shoppingcentre.PetsForSale[0].Name}");
                        player.Pet = shoppingcentre.PetsForSale[0];
                        Console.ReadLine();
                    }
                }
                else if (gameState.OptionInput is "pet rat" or "5")
                {
                    if (player.Money < shoppingcentre.PetsForSale[1].Value)
                    {
                        Console.Clear();
                        Console.WriteLine("You don't have enough money for this yet!");
                        Console.ReadLine();
                    }
                    else
                    {
                        player.Money -= shoppingcentre.PetsForSale[1].Value;
                        Console.WriteLine($"Bought {shoppingcentre.PetsForSale[1].Name}");
                        player.Pet = shoppingcentre.PetsForSale[1];
                        Console.ReadLine();
                    }
                }
                else if (gameState.OptionInput is "pet cat" or "6")
                {
                    if (player.Money < shoppingcentre.PetsForSale[2].Value)
                    {
                        Console.Clear();
                        Console.WriteLine("You don't have enough money for this yet!");
                        Console.ReadLine();
                    }
                    else
                    {
                        player.Money -= shoppingcentre.PetsForSale[2].Value;
                        Console.WriteLine($"Bought {shoppingcentre.PetsForSale[2].Name}");
                        player.Pet = shoppingcentre.PetsForSale[2];
                        Console.ReadLine();
                    }
                }
            }

            void Battle()
            {
                while (gameState.IsBattling)
                {
                    if (player.Health <= 0 || voldemort.Health <= 0)
                    {
                        gameState.IsBattling = false;
                    }
                    player.Health -= voldemort.Damage;
                    voldemort.Health -= player.Damage;
                    Console.WriteLine($"Player: {player.Health}  Voldemort: {voldemort.Health}");
                }

                Console.ReadLine();
            }
        }
    }
}

