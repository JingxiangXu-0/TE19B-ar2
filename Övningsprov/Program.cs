using System;

namespace Övningsprov
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] frågor =
      {
        "x * 6 = 42 \nVilket värde har x?", "1 + x = 3 \nVilket värde har x?", "3 * x = 6 \nVilket värde har x?"
      };
      int frågaNmr = 0;
      int poäng = 0;
      int svar = 0;
      bool rätt = false;


      Console.WriteLine(frågor[frågaNmr]);

      while (!rätt)
      {
        string answerString = Console.ReadLine();
        rätt = int.TryParse(answerString, out svar);

        if (!rätt)
        {
          Console.WriteLine("Skriv bara siffror!");
        }
      }

      if (svar != 7)
      {
        Console.WriteLine("Du har fel!\n" + svar + " * 6 = " + svar * 6 + "\nDu kom till fråga" + frågaNmr + 1);
      }
      else
      {
        poäng++;
        Console.WriteLine("Korrekt! Du har nu " + poäng + " poäng" + "\nNästa fråga är:");
        frågaNmr++;
        Console.WriteLine(frågor[frågaNmr]);
      }
    }
  }
}
