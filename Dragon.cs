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
            pokeBeat = 4f;
            pokemonType = Types.Fire;
         }

        public override void Attack()
        {
            Console.WriteLine("This will be the first attack of Dragon");
        }

        // override attack function from parent

       
    }
}
