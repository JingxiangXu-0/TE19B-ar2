using System;

namespace Uppgift_4_8
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Skriv ett tal");
      string tal = Console.ReadLine();

      bool finns37 = false;

      for (int i = 0; i < tal.Length; i++)
      {
        if (tal[i] == '3' || tal[i] == '7')
        {
          finns37 = true;
        }
      }
      if (finns37)
      {
        Console.WriteLine("Talet innehåller en 3 och/eller 7");
      }
      else
      {
        Console.WriteLine("Det finns inte någon 3 eller 7 i talet.");
      }
    }
  }
}
