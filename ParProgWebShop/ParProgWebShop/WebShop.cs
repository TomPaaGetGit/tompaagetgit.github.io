using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ParProgWebShop
{
    internal class WebShop
    {
        public List<Game> ShoppingCart;
        public StoreInventory Inventory;
        public WebShop()
        {
            ShoppingCart = new List<Game>();
            Inventory = new StoreInventory();

            while (true)
            {
                Console.WriteLine("Welcome to the shop! ");
                Console.WriteLine("1: Show all available games");
                Console.WriteLine("2: Show only physical games");
                Console.WriteLine("3: Show only downloadable games");
            
                HandleCommand();
            }
        }
        //TODO:
        public void HandleCommand()
        {
            // Skal lese inn input fra brukere her
            // Inventory skal printe ut informasjon basert på valget brukeren tok. 
            Inventory.PrintInventory(Console.ReadLine());
            Console.WriteLine("input the ID of game you want to buy");
            var gameID = Convert.ToInt32(Console.ReadLine());
            var gameToBuy = Inventory.InventoryList.Find(x => x.Id == gameID);
            ShoppingCart.Add(gameToBuy);
            //Sjekk på om spillet skal shippes eller lastes ned
            if (gameToBuy is IPhysicalCopy && !(gameToBuy is IDownloadableCopy))
            {
                PrintShippingMessage(gameToBuy.GameName);
            }
            else if (gameToBuy is IDownloadableCopy && !(gameToBuy is IPhysicalCopy))
            {
                PrintDownloadMessage(gameToBuy.GameName);
            }
            else
            {
                PhysicalOrDownload(gameToBuy.GameName);
            }
            //Print ut med Download eller shipping metoden under
        }

        public void PhysicalOrDownload(string gameName)
        {
            Console.WriteLine("Do you want to download this game?");
            var command = Console.ReadLine();
            if (command.ToUpper() == "Y")
            {
                PrintDownloadMessage(gameName);
            }
            else
            {
                PrintShippingMessage(gameName);
            }
        }
        private void PrintDownloadMessage(string gameName)
        {
            Console.WriteLine($"Game {gameName} will now be downloaded..");
        }
        private void PrintShippingMessage(string gameName)
        {
            Console.WriteLine($"Game {gameName} will be shipped shortly..");
        }
    }
}
