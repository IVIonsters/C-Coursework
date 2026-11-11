namespace tryRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i < 4; i++)
            {
                System.Console.WriteLine("Let's guess the random number!");
                var input = Console.ReadLine();

                int randomNumber = Random.Shared.Next(1, 11);
                // System.Console.WriteLine(randomNumber);

                int.TryParse(input, out int inputValue);
                if (inputValue == randomNumber)
                {
                    System.Console.WriteLine("Congratulations you won!");
                    break;
                }
                else
                {
                    System.Console.WriteLine(" You Lost Loser");
                }
            }
        }
    }
}
/*
4- Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)
*/
