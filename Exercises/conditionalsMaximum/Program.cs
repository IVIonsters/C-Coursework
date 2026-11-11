using System;
using System.Linq;

namespace Maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter 5 numbers separated by commas EX: 1, 2, 3, 4, 5");
            var input = Console.ReadLine();

            var splitValues = input.Split(',');

            //Convert String
            var inputValues = splitValues.Select(s => int.Parse(s));

            // Max Call
            int result = inputValues.Max();
            System.Console.WriteLine(result);
        }
    }
}

/*
5- Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
*/
