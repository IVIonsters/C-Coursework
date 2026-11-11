namespace numberQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { };
            var displayNumbers = new List<int> { };
            System.Console.WriteLine(
                "Please enter as many number's as you would like, or type quit to exit!"
            );
            while (true)
            {
                var input = Console.ReadLine();
                if (int.TryParse(input, out int result))
                {
                    numbers.Add(result);
                }
                else if (input == "quit" || input == "Quit")
                {
                    break;
                }
                else
                {
                    System.Console.WriteLine("Invalid Input");
                }
            }
            System.Console.WriteLine("Your unique numbers display:");
            foreach (var number in numbers)
            {
                if (displayNumbers.Contains(number))
                {
                    continue;
                }
                else
                {
                    displayNumbers.Add(number);
                }
            }
            foreach (var number in displayNumbers)
            {
                System.Console.WriteLine(number);
            }
        }
    }
}
