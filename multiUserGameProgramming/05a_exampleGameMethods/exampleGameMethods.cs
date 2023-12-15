// Bruce Johnson, Example Game Methods, v1.0
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
            Console.WriteLine("Press ENTER to continue throughout game");
            Console.ReadKey();
            Console.WriteLine("Welcome to the Adventure Game!!!");
            Console.ReadKey();
            Console.WriteLine("You find yourself in a Mysterious world...");
            Console.ReadKey();

            ExploreArea();
            bool foundWeapon = FindWeapon();
            winOrLose(foundWeapon);

            Console.WriteLine("Congratulations!! You have completed your grand adventure.");
            Console.ReadKey();
        }

        static void ExploreArea()
        // the player explores the suroundings and finds a cave where you can find magnificent weapon or find nothing.
        {
            Console.WriteLine("While exploring the area you find and enter a Cave.");
            Console.ReadKey();
        }

        static bool FindWeapon()
        // This method simulates the chance of finding a weapon and returns a boolean.
        {
            bool foundWeapon;
            Random random = new Random();
            int randNumber = random.Next(1,3); // 50% chance of finding treasure
            if (randNumber == 2)
            {
                foundWeapon = true;
            }
            else
            {
                foundWeapon = false;
            }

            Console.WriteLine("You look around and come across a mysterious chest.");
            Console.ReadKey();
            if (foundWeapon)
            {
                Console.WriteLine("You found a powerful weapon");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("you search vigorously but find nothing of significance");
                Console.ReadKey();
            }

            return foundWeapon;
        }

        static void winOrLose(bool foundWeapon)
        // Win or loose vs the monster
        {
            Random random = new Random();
            int randNumber = random.Next(1,11); // 50% chance of finding treasure
            
            Console.WriteLine("A fearsome monster appears and you attack");
        
            int attempts = 0;
            
            while (attempts < 5)
            {
                Console.ReadKey();
                randNumber = random.Next(1,11);
            
                if (foundWeapon && randNumber > 5 )
                {
                    Console.WriteLine("You have kill the monster and the world is saved you WIN!!!.");
                    System.Environment.Exit(0);
                }
                else if (foundWeapon && randNumber < 6)
                {
                    Console.WriteLine("You have missed, try again.");
                }
                else if (foundWeapon == false && randNumber == 1)
                {
                    Console.WriteLine("You have kill the monster and the world is saved you WIN!!!.");
                    System.Environment.Exit(0);

                }else if (foundWeapon == false && randNumber > 1)
                {
                    Console.WriteLine("You have missed, try again.");
                }
                else
                {
                    Console.WriteLine("ERROR!!!");
                    System.Environment.Exit(0);
                }
                
                attempts++;
            }
            Console.WriteLine("\nYou have failed to kill the monster, YOU LOSE!!!");
            System.Environment.Exit(0);

        }
    }
}
// Code reviewe by Jamiya Bates