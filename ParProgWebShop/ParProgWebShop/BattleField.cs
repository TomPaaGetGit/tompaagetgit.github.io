using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgWebShop
{
    internal class BattleField : Game, IPhysicalCopy, IDownloadableCopy
    {
        public BattleField() : base("BattleField", 1, 150)
        {
            //GameName = "Battlefield 4";
            //Price = 599;
            //Id = 24;
        }
    }
}
