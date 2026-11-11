namespace listExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameList = new List<string> { };
            while (true)
            {
                System.Console.WriteLine("Please enter a name ... or don't");
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                else
                {
                    nameList.Add(input);
                }
            }

            // foreach (var name in nameList)
            // {
            //     System.Console.WriteLine(name);
            // }
            if (nameList.Count == 0)
            {
                System.Console.WriteLine("You are not loved");
            }
            else if (nameList.Count == 1)
            {
                System.Console.WriteLine("You are loved a little by " + nameList[0]);
            }
            else if (nameList.Count == 2)
            {
                System.Console.WriteLine(
                    "You are loved a lot by " + nameList[0] + " and " + nameList[1]
                );
            }
            else
            {
                System.Console.WriteLine(
                    "You gotta whole lotta love "
                        + nameList[0]
                        + " and "
                        + nameList[1]
                        + " among "
                        + (nameList.Count - 2)
                        + " others"
                );
            }
        }
    }
}
