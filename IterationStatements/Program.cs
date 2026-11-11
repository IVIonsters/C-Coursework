/*
for loop
foreach loop
while loop
do while loop

Break - jumps out of a loop
continue - jumps to next iteration
*/

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            //For Loops
            for (var i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    System.Console.WriteLine(i);
                }
            }

            for (var i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    System.Console.WriteLine(i);
                }
            }
            System.Console.WriteLine("----------------------------");

            //ForEach Loops
            var name = "John Smith";

            for (var i = 0; i < name.Length; i++)
            {
                System.Console.WriteLine(name[i]);
            }

            //For Each Version
            foreach (var character in name)
            {
                System.Console.WriteLine(character);
            }

            //Numbers variation
            var numbers = new int[] { 1, 2, 3, 4 };

            foreach (var number in numbers)
            {
                System.Console.WriteLine(number);
            }
            System.Console.WriteLine("----------------------------");
            //While Loops
            while (true)
            {
                System.Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                    break;

                System.Console.WriteLine("@Echo: " + input);
            }
        }
    }
}
