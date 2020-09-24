using System;

namespace Uppgift_3._6
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hur gammal är du?");
      double ålder = double.Parse(Console.ReadLine());

      if (ålder > 65 || ålder >= 10 && ålder <= 18)
      {
        Console.Write("Du får rabbat! :)");
      }
      else
      {
        Console.Write("Du får inte rabbat! :)");
      }
    }
  }
}
