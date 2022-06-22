using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgWebShop
{
    internal class PUBG : Game, IDownloadableCopy
    {
        public PUBG() : base("Player Unkown's BattleGrounds", 4, 100)
        {
           // this.GameName = "Player Unknown's BattleGrounds";
           // this.Price = 100;
           // this.Id = 4;
        }
    }
}
