using System.Text;

namespace stringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();
            // builder.Append('-', 10);
            // builder.AppendLine();
            // builder.Append("Header");
            // builder.AppendLine();
            // builder.Append('-', 10);

            // builder.Replace('-', '+');
            // //Removes 10 characters
            // builder.Remove(0, 10);
            // //Let's you add based on a "base position 0 being the start" adding lines back in we removed earlier.
            // builder.Insert(0, new string('-', 10));
            // System.Console.WriteLine(builder);

            // System.Console.WriteLine("First Char: " + builder[0]);
            // ^^ same as above just cleaner
            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                //Removes 10 characters
                .Remove(0, 10)
                //Let's you add based on a "base position 0 being the start" adding lines back in we removed earlier.
                .Insert(0, new string('-', 10));
            System.Console.WriteLine(builder);

            System.Console.WriteLine("First Char: " + builder[0]);
        }
    }
}
