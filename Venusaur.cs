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
            //Console.WriteLine("This is Venu's Attack");

            //Venu's Turn:
            Console.WriteLine("Its the Venu's turn");
            Console.WriteLine("Press N to Attack or M to Heal");

            string enemyChoice = Console.ReadLine();

            if (enemyChoice == "N")
            {
                health -= attackPower;
                Console.WriteLine($"The Dragon got a bit Hurt itseems {attackPower}");
            }

            else if (enemyChoice == "M")
            {
                health += pokeHeal;
                Console.WriteLine($"Venusaur has been loaded now and another Challenge arises for the Player {pokeHeal}");
            }

        }

    }
}

