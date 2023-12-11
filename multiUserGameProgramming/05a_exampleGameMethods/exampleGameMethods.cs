// Bruce Johnson, Example Game Methods, v0.3
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

        static string playerAttack()
        {

        }

        static string chestLoot()
        {
            
        }
    }
}
// Code reviewe by Jamiya Bates