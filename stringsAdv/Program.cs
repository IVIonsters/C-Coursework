namespace stringsAdvance
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Zachary Polof ";
            System.Console.WriteLine("Trim: '{0}'", fullName.Trim());
            System.Console.WriteLine("ToUpper '{0}'", fullName.Trim().ToUpper());

            System.Console.WriteLine("-----------------------------");

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            System.Console.WriteLine("First Name: " + firstName);
            System.Console.WriteLine("Last Name: " + lastName);

            System.Console.WriteLine("-----------------------------");
            // Same thing using "split"
            var names = fullName.Split(' ');
            System.Console.WriteLine("First Name: " + names[0]);
            System.Console.WriteLine("Last Name: " + names[1]);

            //Replace Method
            System.Console.WriteLine(fullName.Replace("Zachary", "Zach"));

            System.Console.WriteLine("-----------------------------");

            //validation
            if (String.IsNullOrWhiteSpace(" "))
            {
                System.Console.WriteLine("Invalid");
            }

            var str = "25";
            var age = Convert.ToByte(str);
            System.Console.WriteLine(age);

            float price = 29.95f;
            System.Console.WriteLine(price.ToString("C"));
        }
    }
}
