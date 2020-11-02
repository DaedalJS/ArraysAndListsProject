using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            // DONE
            int[] numbers = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            // DONE
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();
            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            // DONE
            foreach (int x in numbers)
            {
                if (x % 2 != 0)
                {
                    odds.Add(x);
                }
                else
                {
                    evens.Add(x);
                }
            }
            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            // DONE
            Console.WriteLine("Evens");
            foreach (int even in evens) { Console.WriteLine(even); }
            Console.WriteLine("\n \n \nOdds");
            foreach (int odd in odds) { Console.WriteLine(odd); }
        }
    }
}
