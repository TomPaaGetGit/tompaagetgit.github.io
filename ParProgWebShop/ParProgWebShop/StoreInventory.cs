using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgWebShop
{
    internal class StoreInventory
    {
        public List<Game> InventoryList { get; set; }
        public StoreInventory()
        {
            InventoryList = new List<Game>();
            InventoryList.Add(new PUBG());
            InventoryList.Add(new PokemonLetsGoEvee());
            InventoryList.Add(new CyberPunk());
            InventoryList.Add(new BattleField());
        }

        public List<Game> ListPhysicalItems()
        {
            // for å finne alle elementene i InventoryList som selges i fysisk format 
            return InventoryList.Where(Game => Game is IPhysicalCopy).ToList();
        }

        public List<Game> ListDownLoadable()
        {
            return InventoryList.Where(Game => Game is IDownloadableCopy).ToList();
        }

        //StoreInventory skal også ha metoder for å printe ut spillinformasjon basert på brukerinput i consollen. Fullfør også det som mangler for å printe ut infoen til hvert spill.
        public void Print(List<Game> printableGames)
        {
            foreach (var game in printableGames)
            {
                game.PrintGameNameAndPrice();
            }
        }
        public void PrintInventory(string command)
        {
            if (command == "1")
            {
                Print(InventoryList);
            }
            else if (command == "2")
            {
                Print(ListPhysicalItems());
            }
            else
            {
                Print(ListDownLoadable());
            }
        }
    }
}
