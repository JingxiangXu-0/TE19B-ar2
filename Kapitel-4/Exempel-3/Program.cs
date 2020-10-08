using System;

namespace Exempel_3
{
  class Program
  {
    static void Main(string[] args)
    {
      string name = "";

      // Körs så många gånger som behövs för att 
      // användaren ska förstå att hen ska skriva "Micke"
      while (name != "Micke")
      {
        Console.WriteLine("Skriv ditt namn:");
        name = Console.ReadLine();
      }
      //   // För att loopa 10 ggr
      //   int i = 10;
      //   while (i > 0)
      //   {
      //     Console.WriteLine(i);
      //     i--;
      //   }
    }
  }
}
