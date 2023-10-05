// Bruce Johnson, Number Guess, v0.5
/*
Generate secret number from a defined range of numbers (i.e. 0-10, 0-50, 0-100). 
Print game instructions including range and num. of guesses allowed. 
    MATCH == first player to score 3 points.
    ROUND == guessig a specific number, until correct or no more attempts 
Ask the player what difficulty the ywant to play on.
Ask the player what their guess is.
Determine if guess is correcr or not.
    If guess is correct {
        Tell them they have guesses correctly.
        Award the player a point
    } else {
        Tell them they are wrong.
        Tell player if guess is too high or too low.
        Check to see if they have any guesses remaining {
            if guess remain: {
                allow player to guess again.
            } else {
                CPU wins the round.
            }
        }
    }

*/
using System;

namespace numberGuess
{
    class numberGuess
    {
        static void Main(string[] args)
        {
           int secretNumber = -1;
           int numGuesses = 0; // Number of guesses player is ALLOWED.
           int numAttempts = 0; // Number of guesses TAKEN.
           int playerGuess = 0;
           int playerScore = 0;
           int cpuScore = 0;
           string difficulty = "";
           int rangeMin = -1;
           int rangeMax = -1;  

           Console.WriteLine("Welcome to the number Guess Game!\nYou will select a difficulty next.\n");
           Console.WriteLine("Easy Mode: Range is 0 - 10 with 4 gueses.\nNormal Mode: Range is 0 - 25 with 3 gueses.\nHard Mode is 0 - 50 with 2 guesses.\n")

           // DIFFICULTY SELECTION
           Console.WriteLine("Please type Easy, Normal, or Hard and press ENDRER.");
           difficulty = Console.ReadLine();
           // Console.ReadLine() will save to STRING by default.
           Console.WriteLine("You have selected " + difficulty);
           if (difficulty == "Easy") {
               rangeMin = 0;
               rangeMax = 10;
               numGuesses = 4
           } else if (difficulty == "Normal") {
               rangeMin = o;
               rangemax = 25;
               numGuesses = 3;
           } else if (difficulty == "Hard") {
               rangeMin = 0;
               rangeMax = 50;
               numGuesses = 2;
           } else {
               // Code to run if no difficulty is selected.
               Console.WriteLine("No difficulty slescted correctly, defaulting to Normal.\n");
               rangeMin = 0;
               rangeMax = 25;
               rangeGuesses = 3;      
           }
           Console.WriteLine("Minimum: " + rangeMin);
           Console.Wrieline("Maximum: " + rangeMax);
           Console.WriteLine("Num. Guesses: " + numberGuesses);

           // START THE MATCH!
           while (playerScore != 3 && cpuScore != 3) {
               // Any code you want to run BEFORE eac hround goes here.
               // GENERATE SERET NUMBER
               Random rndNum = new Random(); 
               secretNumber = rndNum.Next(rangeMin, rangeMax);
               Console.WriteLine("player Score: " + playerScore + "\n");
               Console.WriteLine("CPU Score: " + cpuScore + "\n");
               // START EACH ROUND
               for ( int i = 0; i , numGuesses ; i ++) {
                   // Code to guess number goes here.
                   Console.WriteLine("You have used " + numAttempts + " this round.\n");
                   Console.WriteLine("You must guess between " + rangeMin + "and " +  rangeMax + ".\n");
                   playerGuess = System.Convert.ToInt32(Console.ReadLine());
                   if (playerGuess == secretNumber) {
                       // Print a seccess message!
                       playerScore++;
                       break;
                   } else {
                       if (playerGuess > secretNumber) {
                           Console.WriteLine("Your guess is too high!\n");
                       } else {
                           Console.WriteLine("Your guess is too low!\n");
                       }
                   }
                   numAttempts++;
               }
               if (playerGuess != secretNumber) {
                   cpuScore++;
                   // Print a round lost message to the console
               } 
           }
           if (playerScore >= 3) {
               Console.WriteLine("You have won the game!\n");
           } else {
               Console.WriteLine("You have lost the game!\n");
           }

        }

    }
}
