using System;

namespace Projekt_2
{

  public class Allafrågor
  {
    public string FrågorText;
    public string FrågorSvar;

  }

  class Program
  {
    static void Main(string[] args)
    {
      int AntalRätt = 0;
      int val = 0;
      int fråga = 0;


      Console.WriteLine("Vad heter du?");
      string namn = Console.ReadLine();

      Console.WriteLine("\nHejsan " + namn + "! Välkommen Till Menyn!");

      while (val != 2)
      {
        Console.WriteLine("Välj ett av alternativen.");
        Console.WriteLine("1. Starta Spelet");
        Console.WriteLine("2. Avsluta programmet");
        Console.Write("Jag väljer alternativ : ");
        val = int.Parse(Console.ReadLine());
        break;
      }

      switch (val)
      {
        case 1:
          Console.WriteLine("Lycka till! Du är nu på fråga: " + fråga);
          fråga++;
          break;

        case 2:
          Console.WriteLine("Då va det slut! \nDu fick " + AntalRätt + "p. Vill " + namn + " spela igen?");
          break;

        case 3:
          Console.WriteLine("Fel :( " + "\nDu är nu på fråga: " + fråga);
          fråga++;
          break;

        case 4:
          Console.WriteLine("Rätt :) " + "\nDu är nu på fråga: " + fråga);
          AntalRätt++;
          fråga++;
          break;

        default:
          break;
      }
    }
    static void Frågor()
    {
      Allafrågor Fråga1 = new Allafrågor();
      Fråga1.FrågorText = "Vad är 1 + 1?";
    }
  }
}

