using System;

namespace Uppgift_5_5
{
  class Program
  {
    static void Main(string[] args)
    {
      int antalÅlder = 0;
      string svar = "";
      int[] år = new int[100];

      do
      {
        Console.WriteLine("Skriv in en ålder");
        år[antalÅlder] = int.Parse(Console.ReadLine());
        antalÅlder++;

        if (antalÅlder >= år.Length)
        {
          Console.WriteLine("Programmet har inte plats för fler åldrar");
          break;
        }
        else
        {
          Console.WriteLine("Vill du skriva in fler åldrar?");
          svar = Console.ReadLine();
        }
      } while (svar != "n" && antalÅlder < år.Length);

      Console.WriteLine("Här är åldrarna du skrev:");
      for (int i = 0; i < antalÅlder; i++)
      {
        Console.WriteLine(år[i]);
      }
    }
  }
}