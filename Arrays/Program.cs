using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new int[3];
            number[0] = 1;

            System.Console.WriteLine(number[0]);
            System.Console.WriteLine(number[1]);
            System.Console.WriteLine(number[2]);
            System.Console.WriteLine("-------------------");
            var flags = new bool[3];

            System.Console.WriteLine(flags[0]);
            System.Console.WriteLine(flags[1]);
            System.Console.WriteLine(flags[2]);
            System.Console.WriteLine("-------------------");
            var names = new string[3] { "Jack", "John", "Mary" };

            var numbers = new[] { 3, 7, 9, 2, 14, 6 };
            //Length
            System.Console.WriteLine("Length: " + numbers.Length);
            System.Console.WriteLine("-------------------");
            //IndexOf()
            var index = Array.IndexOf(numbers, 9);
            System.Console.WriteLine("Index of 9: " + index);
            System.Console.WriteLine("-------------------");
            // CLear()
            Array.Clear(numbers, 0, 2);

            System.Console.WriteLine("Effect of clear()");
            foreach (var n in numbers)
            {
                System.Console.WriteLine(n);
            }
            System.Console.WriteLine("-------------------");

            //Copy
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            foreach (var a in another)
            {
                System.Console.WriteLine(a);
            }
            System.Console.WriteLine("-------------------");

            //Sort()
            Array.Sort(numbers);
            System.Console.WriteLine("Effect of Sort()");
            foreach (var b in numbers)
            {
                System.Console.WriteLine(b);
            }
            System.Console.WriteLine("-------------------");

            //Reverse()
            Array.Reverse(numbers);
            System.Console.WriteLine("Effect of Reverse()");
            foreach (var c in numbers)
            {
                System.Console.WriteLine(c);
            }
        }
    }
}
