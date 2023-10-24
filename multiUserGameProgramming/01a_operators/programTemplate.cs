// Bruce Johnson, Program Template, v0.4
using System;

namespace Operatrs
{
    class Programs
    {
        static void Main(string[] args)
        {
            // Create TWO string, Integer, and Float variables
            string myString1 = "I luv guitar"
            string myString2 = "Jazz feels like Luv"

            int myInt1 = 333
            int myInt2 = 111

            float myFloat1 = 0.0F
            float myFloat2 = 3.33

            // Arithmetic Opertors
            Console.WriteLine(myInt1 + myInt2);
            Console.WriteLine(myString1 + myString2);
            Console.WriteLine(myFloat1 + myFloat2);
            Console.WriteLine(myInt1 + myFloat2);

            Console.WriteLine(myInt1 - myInt2);
            //Console.WriteLine(myString1 - myString2);
            Console.WriteLine(myFloat1 - myFloat2);
            Console.WriteLine(myInt1 - myFloat2);

            Console.WriteLine(myInt1 / myInt2);
            //Console.WriteLine(myString1 / myString2);
            Console.WriteLine(myFloat1 / myFloat2);
            Console.WriteLine(myInt1 / myFloat2);

            Console.WriteLine(myInt1 * myInt2);
            //Console.WriteLine(myString1 * myString2);
            Console.WriteLine(myFloat1 * myFloat2);
            Console.WriteLine(myInt1 * myFloat2);

            // Modulus 
            Console.Writeline("Modulus");
            Console.Writeline("10 % 2");
            Console.Writeline("9 % 4");

            // Increment
            int myInt3 = 1;
            myInt2++;
            Console.WriteLine(myInt4);

            // Decrement
            int myInt4 = 2;
            myInt3--;
            Console.WriteLine(myInt4)

            // Assignment Operators
            // = THIS ASSIGNMENT OPERATOR THROWS OUT ALL OLD VALUES
            myInt3 = 5;
            // These assignment operators keep old values!!
            // +=
            myInt3 += -1;
            //-=
            myInt3 -= 2;
            // *=
            myInt3 *= 3;
            // /=
            myInt3 /= 2;
            Console.WritenLine(myInt3);

            // Comparison Operators
            // Is Equal To
            Console.WrittenLine(5 == 3);
            // Not Equal To
            Console.WriteLine(3 != 2);
            // Greater Than
            Console.WriteLine(5 > 3);
            // Greater Than or Equal to
            Console.WriteLine(55 >= 75)
            // Less Than
            Console.WriteLine(-1 , -2);
            // Less Than or Equal To
            Console.WritenLine(1 <= 5);


            // Logicl Operators
            // And -- ALL CONDITIONS MUS BE TRUE FOR THE WHOLE THING TO BE TRUE. 
            Console.WritenLine(3 > 2 && 2 == 3); // True and True = True
            Console.WriteLine(3 > 2 && 5 > 6); // True and False = False
            //Or -- ONE conditions msut be true for the whole statement to be true.
            Console.WriteLine(5 < 9 || 5 != 4); // True or True == True 
            Console.WriteLine(9 < 10 || 3 > 5); // True or False == True
            // Not -- Find the 'opposite' value.
            Consoole.WriteLine(!(5 > 4 )); // 
        }
    }
}
