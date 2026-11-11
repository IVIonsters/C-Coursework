namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Type a number: ");
            var input = Console.ReadLine();
            var product = 1;
            if (int.TryParse(input, out int inputValue))
            {
                System.Console.WriteLine($"Input value: {inputValue}");
                for (var i = inputValue; i >= 1; i--)
                {
                    product = i * product;
                }
                System.Console.WriteLine(inputValue + "! = " + product);
            }
            else
            {
                System.Console.WriteLine("Invalid Input Type");
            }
        }
    }
}
/*


3- Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
*/
