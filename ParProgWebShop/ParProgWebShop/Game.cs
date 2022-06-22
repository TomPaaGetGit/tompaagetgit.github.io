using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgWebShop
{
    internal class Game
    {
        public string GameName { get; set; }
        public int Id { get; set; }
        public int Price { get; set; }

        public Game(string gameName, int id, int price)
        {
            GameName = gameName;
            Id = id;
            Price = price;
        }

        public void PrintGameNameAndPrice()
        {
            Console.WriteLine($"Item: {GameName} Price: {Price} ID: {Id}");
        }
    }

}
