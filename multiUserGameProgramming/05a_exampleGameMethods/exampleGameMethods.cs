// Bruce Johnson, Example Game Methods, v0.6
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

            Console.WriteLine("Congratulations!! You have completed your grand adventure.");
        }

        static void ExploreArea()
        // the player explores the suroundings and finds a cave where you can find magnificent weapon or find nothing.
        {
            Console.WriteLine("While exploring the area you find and enter a Cave.")
        }

        bool foundWeapon = FindWeapon();

        if (foundWeapon)
        {
            Console.WriteLine("You found a powerful weapon")
        }
        else
        {
            Console.WriteLine("you search vigorously but find nothing of significance")
        }

        static bool FindWeapon()
        // This method simulates the chance of finding a weapon and returns a boolean.
        {
            Console.WriteLine("While exploring, you come across a mysterious glowig chest.")

            Random random = new Random();
            return random.Next(2) == 0; // 50% chance of finding treasure
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

        static int CalculateDamage(int enemyAttackPower)
        // Calculates the damage taken during a battle and returns the damage value.
        {
            int playerDefense = 10;
            int damageTaken = enemyAttackPower - playerDefense;

            return Math.Max(0, damageTaken);
        }
    }
}
// Code reviewe by Jamiya Bates