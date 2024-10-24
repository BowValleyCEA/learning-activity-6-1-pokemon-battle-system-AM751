namespace LA6_1
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Choose one among them:\n");
            string one = "Grass, ";
            string two = "Electric, ";
            string three = "Water, ";
            string four = "Fire, ";
            string five = "Normal, ";
            Console.WriteLine(one + two + three + four + five);
            Console.ReadLine();

            int playerHealth = 10;
            int enemyHealth = 10;

            int playerBeat = 3;
            int enemyBeat = 2;

            int playerHeal = 2;
            int enemyHeal = 2;




            while (playerHealth > 0 && enemyHealth > 0)
            {
                //Player's Turn:
                Console.WriteLine("Its your turn to attack the Enemy or get Loaded yourself...");
                Console.WriteLine($"Health - {playerHealth}. Enemy Health - {enemyHealth}");
                Console.WriteLine("Press X to attack or Z to Heal");

                string playerChoice = Console.ReadLine();

                if (playerChoice == "x")
                {
                    enemyHealth -= playerBeat;
                    Console.WriteLine($"The Enemy got a mighty attack by the PLayer {playerBeat}");
                }

                else if (playerChoice == "z")
                {
                    playerHealth += playerHeal;
                    Console.WriteLine($"The Player has something now which helped them to get Healed {playerHeal}");
                }

                //Enemy's Turn:
                Console.WriteLine("Its the Enemy's turn");
                Console.WriteLine("Press N to Attack or M to Heal");

                string enemyChoice = Console.ReadLine();

                if (enemyChoice == "N")
                {
                    playerHealth -= enemyBeat;
                    Console.WriteLine($"The Player got a bit Hurt itseems {enemyBeat}");
                }

                else if (enemyChoice == "M")
                {
                    enemyHealth += enemyHeal;
                    Console.WriteLine($"Evil has been loaded now and another Challenge arises for the Player {enemyHeal}");
                }

                //Win Conditions:
                if (playerHealth > 0)
                {
                    Console.WriteLine("Congrats to the Player... You won the Game");
                }

                else if (playerHealth <= 0)
                {
                    Console.WriteLine("Oops to the Player.... You've lost");
                }

                if (enemyHealth < 0)
                {
                    Console.WriteLine("Feeling pitty on the Enemy... You've lost the game");
                }

                else if (enemyHealth <= 0)
                {
                    Console.WriteLine("Evil guy WON... Good guy Lost");
                }
            }
        }
    }

}