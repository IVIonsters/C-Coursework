namespace demoPath
{
  class Program
  {
    static void Main(string[] arg)
    {
      var path = @"C:\Users\Zacha\Documents\developer\C-Coursework\demoPath\demoPath.sln";

      var dotIndex = path.IndexOf('.');
      var extension = path.Substring(dotIndex);

      System.Console.WriteLine("Extension: " +Path.GetExtension(path));
      System.Console.WriteLine("File Name: " + Path.GetFileName(path));
      System.Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path));
      System.Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));

    }
  }
}