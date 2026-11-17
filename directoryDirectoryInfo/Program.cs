namespace directoryDirectoryInfo
{
  class Program
  {
    static void Main(string[] args)
    {
      Directory.CreateDirectory(@"c:\temp\folder1");
      // var files = Directory.GetFiles(@"C:\Users\Zacha\Documents\developer\C-Coursework", "*.dll", SearchOption.AllDirectories);
      // foreach(var file in files)
      // {
      //   System.Console.WriteLine(file);
      // }
      var directories = Directory.GetDirectories(@"C:\Users\Zacha\Documents\developer\C-Coursework", "*.*", SearchOption.AllDirectories);
      foreach(var directory in directories)
      {
        System.Console.WriteLine(directory);
      }
      Directory.Exists("...");

      var directoryInfo = new DirectoryInfo("...");
      directoryInfo.GetFiles();
      directoryInfo.GetDirectories();
    }
  }
}