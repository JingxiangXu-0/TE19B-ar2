using System;

namespace Uppgift_5_8
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Skriv en mening");
      string mening = Console.ReadLine();

      string[] orden = mening.Split(' ');

      foreach (string ord in orden)
      {
        Console.WriteLine(ord);
      }
    }
  }
}
