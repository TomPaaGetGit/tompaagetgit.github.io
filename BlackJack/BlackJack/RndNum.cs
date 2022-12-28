using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class RndNum
    { 
        public int RandomNumber()
        {
            Random rnd = new Random();
            int RndNum = rnd.Next(53);
            return RndNum;
        }
    }
}
