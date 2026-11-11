/*
1- Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
*/
using System.Linq;

namespace consecutiveCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a few numbers in a hyphen format Ex: 5-6-7-8-9");
            var input = Console.ReadLine();
            System.Console.WriteLine(input);

            //split into numbers
            var numbers = input.Split('-').Select(part => int.Parse(part)).ToArray();

            if (numbers[0] < numbers[1])
            {
                var isConsecutive = true;
                for (var i = 0; i < numbers.Length; i++)
                {
                    System.Console.WriteLine("Looping");
                }
            }
            else
            {
                System.Console.WriteLine("Not Consecutive");
            }
        }
    }
}
