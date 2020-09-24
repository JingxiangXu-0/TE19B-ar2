using System;

namespace Exempel_1
{
  class Program
  {
    static void Main(string[] args)
    {
      //   Console.WriteLine("Hello hur gammal är du? (Svara i hela antal år)");
      //   int ålder = int.Parse(Console.ReadLine());

      //   if (ålder == 18)
      //   {
      //     Console.Writeline("Du är mindig. Du får ta körkort.");
      //   }
      //   if (ålder <= 15)
      //   {
      //     Console.Writeline("Du är yngre än 15 år. Du får köra moped.");
      //   }
      //   if (ålder < 15)
      //   {
      //     Console.Writeline("Du är yngre än 15 år men du kan gå.");
      //   }
      // }

      Console.Write("vem var statsminister i svergie 1979? ");
      string statsminister = Console.ReadLine();

      //   if (statsminister == "Palme" || statsminister == "palme")
      //   {
      //     Console.WriteLine("Rätt svar!");
      //   }

      statsminister = statsminister.ToLower();
      if (statsminister == "palme")
      {
        Console.WriteLine("Rätt svar!");
      }
      else
      {
        Console.WriteLine("Fel svar!");

      }
    }
  }
}
