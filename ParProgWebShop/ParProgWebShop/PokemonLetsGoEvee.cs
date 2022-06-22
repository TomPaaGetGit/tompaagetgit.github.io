using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgWebShop
{
    internal class PokemonLetsGoEvee : Game, IPhysicalCopy
    {
        public PokemonLetsGoEvee() : base("Pokemon Let's Go Evee", 3, 400)
        {
            //this.GameName = "Pokemon Let's Go Evee";
            //this.Price = 0;
            //this.Id = 0;
        }
    }
}
