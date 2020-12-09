using System;

namespace Uppgift_5_14
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] frågor = new string[4];
      string[] svar = new string[4];

      frågor[0] = "vad är 1+1?";
      svar[0] = "2";

      frågor[1] = "vad är 1+2?";
      svar[1] = "3";

      frågor[2] = "vad är 0+3?";
      svar[2] = "3";

      frågor[3] = "vad är 2+2?";
      svar[3] = "4";

      Console.WriteLine("Välj en fråga (1 - 4)");
      int frågeI = int.Parse(Console.ReadLine()) - 1;

      Console.WriteLine(frågor[frågeI]);
      string anvSvar = Console.ReadLine();

      if (anvSvar == svar[frågeI])
      {
        Console.WriteLine("rätt!");
      }
      else
      {
        Console.WriteLine("fel");
      }

    }
  }
}
