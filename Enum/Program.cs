using System;

namespace CSharpFundamentals
{
  public enum ShippingMethod
  {
    RegularAirMail = 1,
    RegisteredAirMail = 2,
    Express = 3
  }
  class Program
  {
    static void Main(string[] args)
    {
      var method = ShippingMethod.Express;
      System.Console.WriteLine((int)method);
      //Allows you to see original method / convert
      var methodId = 3;
      System.Console.WriteLine((ShippingMethod)methodId);

      //Convert to string
      System.Console.WriteLine(method.ToString());

      //Convert string to Enum
      var methodName = "Express";
      var shippingMethod =(ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
      System.Console.WriteLine(shippingMethod);
    }
  }
}