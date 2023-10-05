﻿// 02_Collections, Bruce Johnson, 10/3/24 v0.1d
using System;

namespace _02_Colletions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Collections are variables that can store multiple values in one variable.

            /* Arrays
            -- Number of elements in an array CANNOT change.
            -- Contents of elements in an array CAN change.
            -- Items in the array are called ELEMENTS.
            -- Arrays are ordered, meaning each item has a fixed position.
            -- The poosition is known as the INDEX.
            -- First element in an array is inde 0.
            */

            // Declaring and Defining an Array
            string[] breakfastFoods = {"Bacon", "Waffles", "Pancakes", "Cereal", "Parfait"};
            int[] testScores = {95, 100, 25, 15, 27, 35};
            float[] GPA = {3.14f, 2.25f, 1.74f, 1.99f, 0.99f, 4.25f};

            // Print Array Contents -- ALL Elements on Single Line
            Console.WriteLine("The elements for each array are:\n");
            Console.WriteLine("breakfastFoods: \n" + String.Join(",", breakfastFoods));
            Console.WriteLine();
            Console.WriteLine("testScores: \n" + String.Join(",", testScores));
            Console.WriteLine();
            Console.WriteLine("GPA: \n" + String.Join(",", GPA));
            Console.WriteLine();

            /* Print Array Contents -- Each Element on Separate Line 
            Console.WriteLine("The elements for each array are:\n");
            Console.WriteLine("breakfastFoods: \n" + String.Join("\n", breakfastFoods));
            Console.WriteLine();
            Console.WriteLine("testScores: \n" + String.Join("\n", testScores));
            Console.WriteLine();
            Console.WriteLine("GPA: \n" + String.Join("\n", GPA));
            Console.WriteLine();
            */

            // Determining Array Length
            Console.WriteLine("The length of each array is:/n");
            Console.WriteLine("breakfastFoods: " + breakfastFoods.Length);
            Console.WriteLine("testScores: " + testScores.Length);
            Console.WriteLine("GPA: " + GPA.Length);



 
        }
    }
}