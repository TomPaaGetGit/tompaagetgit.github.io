using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgWebShop
{
    internal class CyberPunk : Game, IPhysicalCopy, IDownloadableCopy
    {
        public CyberPunk() : base("Cyberpunk", 2, 250){}
    }
}
