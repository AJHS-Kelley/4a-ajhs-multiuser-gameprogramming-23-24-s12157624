// Bruce Johnson, Number Guess, v0.4
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
           int playerScore = 0:
           int cpuScore = 0;
           string difficulty = "";
           int rangeMin = -1;
           int rangeMax = -1;  

           Console.WriteLine("Welcome to the number Guess Game!\nYou will select a difficulty next.\n");
           Console.WriteLine("Easy Mode: Range is 0 - 10 with 4 gueses.\nNormal Mode: Range is 0 - 25 with 3 gueses.\nHard Mode is 0 - 50 with 2 guesses.\n")

           // DIFFICULTY SELECTION
           Console.WriteLine("Please type Easy, Normal, or Hard and press ENDRER.")
           difficulty = Console.ReadLine();
           // Console.ReadLine() will save to STRING by default
           Console.WriteLine("You have selected" + difficulty);
           if (difficulty == "Easy") {
               rangeMin = 0;
               rangeMax = 10;
               numGuesses = 4

           } else if (NORMAL MODE) {
               rangeMin = o;
               rangemax = 25;
               numGuesses = 3;

           } else if (HARD MODE) {
               rangeMin = 0;
               rangeMax = 50;
               numGuesses = 2;
           } else {

           }
           Console.WriteLine("Minimum: " + rangeMin);
           Console.Wrieline("Maximum: " + rangeMax);
           Console.WriteLine("Num. Guesses: " + numberGuesses);
        }

    }
}