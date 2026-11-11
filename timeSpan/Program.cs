//TimeSpan

namespace timeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeSpan = new TimeSpan(1, 2, 3);

            var timeSpan1 = TimeSpan.FromHours(1);

            //subtracting 2 datetime objects also creates a timespan
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;

            System.Console.WriteLine("Duration " + duration);

            //properties
            System.Console.WriteLine("Minutes " + timeSpan.Minutes);
            System.Console.WriteLine("Total Minutes " + timeSpan.TotalMinutes);

            //Add
            System.Console.WriteLine("Add Example" + timeSpan.Add(TimeSpan.FromMinutes(8)));

            //Subtract
            System.Console.WriteLine(
                "Subtract Example" + timeSpan.Subtract(TimeSpan.FromMinutes(2))
            );

            //ToString
            System.Console.WriteLine("ToString " + timeSpan.ToString());

            //Parse
            System.Console.WriteLine("Parse " + TimeSpan.Parse("01:02:03"));
        }
    }
}
