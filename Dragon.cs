using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1401_la_starter
{
    internal class Dragon : Pokemon
    {
         public Dragon()
        {
            health = 50f;
            attackPower = 70f;
            pokemonType = Types.Fire;
        }

        // override attack funtion from parent
    }
}
