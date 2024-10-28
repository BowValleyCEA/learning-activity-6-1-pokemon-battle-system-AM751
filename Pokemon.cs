using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
//Access modifiers means: public, private, protected and internal.
namespace game1401_la_starter
{
    public enum Types
    {
        Grass,
        Electric,
        Water,
        Fire,
        Intelligence
    }
    internal class Pokemon
    {
        protected float attackPower = 5f;
        protected float health = 100f;
        protected float pokeBeat = 5f;
        protected float pokeHeal = 3f;
 
        protected Types pokemonType;


        public virtual void Attack()
        {
            Console.WriteLine("This will be the first attack");
        }

        public void heal()
        {
            health += 15f;
        }
    }
}

    

        
    

    

