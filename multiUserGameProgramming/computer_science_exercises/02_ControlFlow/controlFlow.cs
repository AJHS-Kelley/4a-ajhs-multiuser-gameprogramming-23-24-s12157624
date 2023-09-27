// Bruce Johnson, Control Flow, v0.5
using System;

namespace controlFlow
{
    class controlFlow
    {
        static void Main(string[] args)
        {
            // DECLARATIONS
            string favColor = "Purple";
            int luckyNumber = 3;
            float myGPA = 3.2F;
            int myAge = 16
            bool pineappleOnPizza = false;

            // if Statements -- Check for a single condition!
            if (favColor == "Pink") {
                Console.WriteLine("Pink is beautiful");
            }

            if (myGPA == "0.01F") {
                Console.WriteLine("0.01 wow you'r smart");
            }

            // is - else Statement -- Checks for a single condition, but has two actions
            if (myAge > 15) {
                Console.WriteLine("you are eligible to drive");   
            } else {
                Console.WriteLine("START WALKING LIL BRO")
            }

            // if -- else if -- else -- Checks ultiple outcomes.
            if (myGPA == 4.0F) {
                Console.WriteLine("Congrats on sraight A grades!");
            } else if (myGPA >= 3.0F) {
                Console.WriteLine("Congrats on making the hono roll!");
            } else if (myGPA >= 2.0F) {
                Console.WriteLine("You are graduation ready!");
            } else {
                Console.WriteLine("You should probably study!");
            }
            // WHEN CHECKING NUMBER VALUSE, START WITH THE HIGHEST VALUSE!!!!

            // NESTED STATEMENTS
            if (pineappleOnPizza == true) {
                Console.WriteLine("Eww, that's gross. You must be a boomer. How old are you?");
                if (myAge > 60) {
                    Console.WriteLine("Just as i suspected! What was it like having a dinosaur growing up?");
                } else {
                    Console.WriteLine("Glad to see you have common sense!");
                }

                // for loop -- Best for when you know the number of iterations 
                /*
                    for (statement1; statement2; statement3){
                    Code to loop.
                }
                statement1 is executed ONCE BEFORE the loop starts.
                statement2 is a CONDITIONAL that is checked EVERYTIME BEFIRE loop starts
                statement3 is executed EVERYTIME after the loop executes
                */

                    for (int i = 0; i < 101; i++) {
                        Console.WriteLine("" + i);
                    }

                    for (int i = 100; i > -1; 1--) {
                        Console.WriteLine(""+ i);
                    }

                    // nested Loops
                    // outer Loop
                    for(int i = 1; i <=2; 1++) {
                        Console
                    }
            }
 
        }
    }
}
