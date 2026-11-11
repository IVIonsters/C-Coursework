namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                System.Console.WriteLine("It's morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                System.Console.WriteLine("It's afternoon.");
            }
            else
            {
                System.Console.WriteLine("It's evening.");
            }

            System.Console.WriteLine("-----------------------");
            bool isGoldCustomer = true;

            float price;
            if (isGoldCustomer)
            {
                price = 19.95f;
            }
            else
            {
                price = 29.95f;
            }
            System.Console.WriteLine(price);
            System.Console.WriteLine("-----------------------");
            // Secondary way to write the same if / else statement
            float priceAlso = (isGoldCustomer) ? 19.95f : 29.95f;
            System.Console.WriteLine(priceAlso);
            
        }
    }
}
