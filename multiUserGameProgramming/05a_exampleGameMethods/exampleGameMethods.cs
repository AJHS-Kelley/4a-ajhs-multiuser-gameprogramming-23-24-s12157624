// Bruce Johnson, Example Game Methods, v0.4
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
        
        static string chestLoot()
        {
            
        }
    }
}
// Code reviewe by Jamiya Bates