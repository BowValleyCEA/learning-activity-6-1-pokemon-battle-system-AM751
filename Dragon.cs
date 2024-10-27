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
            //Console.WriteLine("This will be the first attack of Dragon");

            Console.WriteLine("Its your turn to attack the Enemy or get Loaded yourself...");
            Console.WriteLine($"Health - {health}.");
            Console.WriteLine("Press X to attack or Z to Heal");

            string playerChoice = Console.ReadLine();

            if (playerChoice == "x")
            {
                health -= attackPower;
                Console.WriteLine($"The Enemy got a mighty attack by the PLayer {attackPower}");
            }

            else if (playerChoice == "z")
            {
                health += pokeHeal;
                    
                Console.WriteLine($"The Player has something now which helped them to get Healed {pokeHeal}");
            }
        }

        // override attack function from parent

       
    }
}
