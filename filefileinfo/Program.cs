namespace fileFileInfo
{
  class Program
  {
    static void Main(string[] args)
    {
      var path = @"c:\somefile.jpg";
      // True allows you to overwrite the file if it exists already
      File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);

      File.Delete(path);
      if (File.Exists(path))
      {
        //Do something about path
      }
      var content = File.ReadAllText(path);

      //Same Methods in the fileInfo Class
      var fileinfo = new FileInfo(path);

      fileinfo.CopyTo("...");
      fileinfo.Delete();
      if (fileinfo.Exists)
      {
        //DO something about it already
      }
      
    }
  }
}