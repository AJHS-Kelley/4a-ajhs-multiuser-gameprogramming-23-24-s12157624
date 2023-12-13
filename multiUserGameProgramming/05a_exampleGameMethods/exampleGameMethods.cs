// Bruce Johnson, Example Game Methods, v0.7
using System;

namespace UPDATEFOREACHPROGRAM
{
    class AdventureGame
    
    {
        static void Main()
        { 
            StartAdventure();
        } 

        static void StartAdventure()
        // This method begins the adventure and calls the methods to progress. 
        {
            Console.WriteLine("Welcome to the Adventure Game!!!");
            Console.WriteLine("You find yourself in a Mysterious world...");

            ExploreArea();
            bool foundWeapon = findWeapon();
            BattleEnemy(string monster, int playerHealth = 100);
            winOrLose();

            Console.WriteLine("Congratulations!! You have completed your grand adventure.");
        }

        static void ExploreArea()
        // the player explores the suroundings and finds a cave where you can find magnificent weapon or find nothing.
        {
            Console.WriteLine("While exploring the area you find and enter a Cave.")
        }

        static bool FindWeapon()
        // This method simulates the chance of finding a weapon and returns a boolean.
        {
            bool foundWeapon = FindWeapon();
            Random random = new Random();
            int randNumber = Random.Next(1,3); // 50% chance of finding treasure

            if (randNumber == 2)
            {
                foundWeapon = true;
            }
            else
            {
                foundWeapon = false;
            }
            if (foundWeapon)
            {
                Console.WriteLine("You found a powerful weapon");
            }
            else
            {
                Console.WriteLine("you search vigorously but find nothing of significance");
            }
            Console.WriteLine("While exploring, you come across a mysterious glowig chest.");

            return foundWeapon;
        }

        static void BattleEnemy(string monster, int playerHealth = 100)
        // simultates a battle between player and enemy

        {
            Console.WriteLine($"You encounter a fearsome enemy!");

            int enemyAttackPower = 20;
            int damageTaken = CalculateDamage(enemyAttackPower);

            Console.writeLine($"You too {damageTaken} damage from the {monster}.")

            playerHealth -= damageTaken;

            Console.WriteLine($"Your health: {playerHealth}");
        }

        static int winOrLose()
        // Win or loose vs the monster
        {
            Random random = new Random();
            int randNumber = Random.Next(1,11); // 50% chance of finding treasure

            if (randNumber == 2)
            {
                foundWeapon = true;
            }
            else
            {
                foundWeapon = false;
            }
            if (foundWeapon)
            {
                Console.WriteLine("You found a powerful weapon");
            }
            else
            {
                Console.WriteLine("you search vigorously but find nothing of significance");
            }
            Console.WriteLine("While exploring, you come across a mysterious glowig chest.");  
        }
    }
}
// Code reviewe by Jamiya Bates