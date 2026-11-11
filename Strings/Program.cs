using System;

class Program
{
    static void Main()
    {
        var firstName = "Zachary";
        var lastName = "Polof";

        //Concatenation method
        var fullName = firstName + " " + lastName;
        System.Console.WriteLine(fullName);
        System.Console.WriteLine("-------------------------");

        // System Format option
        var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
        System.Console.WriteLine(myFullName);
        System.Console.WriteLine("-------------------------");

        //System Join Method
        var names = new string[3] { "John", " Jack", " Mary" };
        var formattedNames = string.Join(",", names);
        System.Console.WriteLine(formattedNames);
        System.Console.WriteLine("-------------------------");

        //Verbatim Strings
        var text =
            @"Hi John
                Look into the following paths
                c:\folder1\folder2
                c:\folder3\folder4:";
        System.Console.WriteLine(text);
    }
}
