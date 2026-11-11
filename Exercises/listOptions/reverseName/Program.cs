namespace reverseName
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter your name!");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                System.Console.WriteLine("No Name Entered");
            }
            else
            {
                char[] inputArray = input.ToCharArray();
                Array.Reverse(inputArray);

                string reversedArray = new string(inputArray);
                System.Console.WriteLine("Let's reverse it! " + reversedArray);
            }
        }
    }
}
