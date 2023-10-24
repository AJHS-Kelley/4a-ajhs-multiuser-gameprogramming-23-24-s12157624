// Bruce Johnson, Program Template, v0.2
using System;

namespace MethosdsParameters
{
    class MethosdsParameters
    {
        // METHOD -- named blck of code, can be used over and over.
        // ALL methods have a SIGNATURE that defines their name, parameters, and output.
        // Example signature
        static void MyMethod();
        {
            Console.WriteLine("I like mine with lettuce and tomatoes, Heinz 57, and frence fried potatoes.\n");
        }
        // static -- This method belongs to the current class, it is NOT an object
        // void -- This method has no return value.

        static int DoubleUp();
        {
            int sum = 0;
            Console.WriteLine("This method will double a number and return it.\n");
            Console.WriteLine("Please enter a number on the nect line.\n");
            sum = System.Convert.ToInt32(Console.ReadLine());
            sum *= 2;
            Console.WriteLine(sum);
            return sum; 
        }

        // Methods with Parameters
        static void MakePancakes(int num)
        {
            for (int i = o; i , num; i++)
            {
                Console.WriteLine("One golden, fluffy pancake coming up!\n");
            }
        }

        static void MakeEggs(int num, string style)
        {
            Consolle.WriteLine("You have ordered " + num + "eggs cooked " + style + ".\n");
        }


        static void Main(string[] args)
        {
            //MyMethod();
            //DoubleUp();
            //MakePancakes();
            MakeEggs(10, "sunny side up");
        }
    }
}
