using Microsoft.VisualBasic;

namespace numberSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { };
            while (numbers.Count < 5)
            {
                System.Console.WriteLine("Please enter a number!");
                var input = Console.ReadLine();
                if (int.TryParse(input, out int result))
                {
                    if (numbers.Contains(result))
                    {
                        System.Console.WriteLine("Number already present try again");
                    }
                    else
                    {
                        numbers.Add(result);
                    }
                }
                else
                {
                    System.Console.WriteLine("Invalid Input, Please Try Again");
                    break;
                }
            }
            System.Console.WriteLine("Your Final Set!");
            numbers.Sort();
            foreach (var number in numbers)
            {
                System.Console.WriteLine(number);
            }
        }
    }
}
