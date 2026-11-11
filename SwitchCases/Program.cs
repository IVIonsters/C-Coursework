namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    System.Console.WriteLine("It's Autumn.. beautiful season");
                    break;

                case Season.Summer:
                    System.Console.WriteLine("Perfect for the beach");
                    break;

                default:
                    System.Console.WriteLine("I Don't understand the season");
                    break;
            }
        }
    }
}
