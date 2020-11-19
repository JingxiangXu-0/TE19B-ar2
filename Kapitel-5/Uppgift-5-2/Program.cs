using System;

namespace Uppgift_5_2
{
  class Program
  {
    static void Main(string[] args)
    {
      //   Skapa ett program där användaren ska få skriva in en lista över alla sporter som hen har testat.Fråga först användaren hur många sporter hen vill skriva in. Därefter ska sporterna skrivas in, en efter en, på var sin rad.Slutligen ska programmet skriva ut namnen på alla sporterna som användaren skrev in.
      Console.WriteLine("hur många sporter vill du skriva?");
      int antal = int.Parse(Console.ReadLine());
      string[] sporter = new string[antal];

      for (int i = 0; i < antal; i++)
      {
        Console.WriteLine("skriv en sport");
        sporter[i] = Console.ReadLine();
      }

      Console.WriteLine("de sporter du skrev är:");
      for (int i = 0; i < antal; i++)
      {
        Console.WriteLine(sporter[i]);
      }

    }
  }
}
