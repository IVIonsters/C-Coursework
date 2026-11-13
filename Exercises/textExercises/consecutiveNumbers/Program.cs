/*
1- Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
*/
namespace consecutiveCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a few numbers in a hyphen format Ex: 5-6-7-8-9");
            var input = Console.ReadLine();

            if (input == null)
            {
                System.Console.WriteLine("Not Consecutive");
                return;
            }

            var parts = input.Split('-');
            var numbers = new int[parts.Length];
            var validInput = true;

            for (var i = 0; i < parts.Length; i++)
            {
                if (!int.TryParse(parts[i], out numbers[i]))
                {
                    validInput = false;
                    break;
                }
            }

            var isConsecutive = validInput && numbers.Length >= 2;

            if (isConsecutive)
            {
                var difference = (long)numbers[1] - numbers[0];
                isConsecutive = difference == 1 || difference == -1;

                for (var i = 1; isConsecutive && i < numbers.Length - 1; i++)
                {
                    isConsecutive = (long)numbers[i + 1] - numbers[i] == difference;
                }
            }

            System.Console.WriteLine(isConsecutive ? "Consecutive" : "Not Consecutive");
        }
    }
}
