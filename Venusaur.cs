using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1401_la_starter
{
   internal class Venusaur : Pokemon
    {
        public Venusaur()
        {
            health = 50f;
            attackPower = 70f;
            pokeBeat = 4f;
            pokemonType = Types.Grass;
        }

        override public void Attack()
        {
            Console.WriteLine("This is Venu's Attack");
        }
   }
}
