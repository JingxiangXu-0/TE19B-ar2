// Skapa ett program som frågar användaren vilket land som vann fotbolls-VM för damer år 2015. Om användaren svarar USA ska programmet skriva ut att svaret var rätt, annars ska programmet skriva ut att svaret var fel. Det ska inte spela någon roll om användaren skriver svaret med stora eller små bokstäver.

using System;

namespace Uppgift_3._2
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Vilket land vann fotballs-vm för damer år 2015?");
      string svar = Console.ReadLine();
      svar = svar.ToLower();
      if (svar == "usa")
      {
        Console.Write("Du har rätt");
      }
      else
      {
        Console.Write("Du har fel");
      }
    }
  }
}
