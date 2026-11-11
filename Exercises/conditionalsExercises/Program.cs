namespace conditionalsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.
            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            System.Console.WriteLine(count);
            System.Console.WriteLine("-----------------------");
            /* 2- Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console. */
            int inputCount = 0;

            while (true)
            {
                System.Console.WriteLine("Type a number: ");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                else
                {
                    inputCount += int.Parse(input);
                }

                System.Console.WriteLine("Values equal: " + inputCount);
            }
            System.Console.WriteLine("-----------------------");
        }
    }
}


/*


3- Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

4- Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)

5- Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
*/
