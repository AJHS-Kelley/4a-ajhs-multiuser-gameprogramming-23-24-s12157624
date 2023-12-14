// Bruce Johnson, Example Game Methods, v0.8
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
            bool foundWeapon = FindWeapon();
            winOrLose(foundWeapon);

            Console.WriteLine("Congratulations!! You have completed your grand adventure.");
        }

        static void ExploreArea()
        // the player explores the suroundings and finds a cave where you can find magnificent weapon or find nothing.
        {
            Console.WriteLine("While exploring the area you find and enter a Cave.");
        }

        static bool FindWeapon()
        // This method simulates the chance of finding a weapon and returns a boolean.
        {
            bool foundWeapon = FindWeapon();
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

            Console.WriteLine("While exploring, you come across a mysterious glowig chest.");
            if (foundWeapon)
            {
                Console.WriteLine("You found a powerful weapon");
            }
            else
            {
                Console.WriteLine("you search vigorously but find nothing of significance");
            }

            return foundWeapon;
        }

        static int winOrLose(bool foundWeapon)
        // Win or loose vs the monster
        {
            Random random = new Random();
            int randNumber = random.Next(1,11); // 50% chance of finding treasure

            if (randNumber > 3 )
            {
                foundWeapon = true;
            }
            else
            {
                foundWeapon = false;
            }

            Console.WriteLine("A fearsome monster appears and you attack");
            
            while apttempts = 5
            {
                randNumber = random.Next(1,11);
            
                if (foundWeapon && randNumber > 5 )
                {
                    Console.WriteLine("You have kill the monster and the world is saved you win.")
                    System.Environment.Exit(0);
                }
                else if (foundWeapon && randNumber < 6)
                {
                    Console.WriteLine("You have missed, The world is doomed and you lose.")
                    System.Environment.Exit(0);
                }
                else if (foundWeapon && randNumber == 1)
                {
                    Console.WriteLine("You have kill the monster and the world is saved you win.")
                    System.Environment.Exit(0);

                }else if (foundWeapon && randNumber > 1)
                {
                    Console.WriteLine("You have missed, The world is doomed and you lose.")
                    System.Environment.Exit(0);
                }
                
            }

        }
    }
}
// Code reviewe by Jamiya Bates