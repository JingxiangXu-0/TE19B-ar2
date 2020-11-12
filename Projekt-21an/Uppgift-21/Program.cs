using System;

namespace Prov_1
{
  class Program
  {
    static void Main(string[] args)
    {
      int val = 0;

      Console.WriteLine("Det här är spelet 21:an, även känd som Blackjack.");

      Console.Write("Ange ditt namn: ");
      string namn = Console.ReadLine();

      Console.WriteLine("\nHejsan " + namn + "! Välkommen Till Menyn!");

      while (val != 4)
      {
        Console.WriteLine("\nVälj ett av alternativen.");
        Console.WriteLine("1. Starta Programmet");
        Console.WriteLine("2. Visa reglerna");
        Console.WriteLine("3. Visa förra vinnaren");
        Console.WriteLine("4. Avsluta programmet");
        Console.Write("Jag väljer alternativ : ");
        val = int.Parse(Console.ReadLine());
        break;
      }

      switch (val)
      {
        case 1:
          Console.WriteLine("Spelet startar");
          break;
        case 2:
          Console.WriteLine("Spelets regler:\n\nDitt mål är att tvinga datorn att få mer än 21 poäng. \nDu får poäng genom att dra kort, varje kort har 1-10 poäng. \nTryck på en knapp för att visa att du har förstått");
          Console.ReadLine();

          Console.WriteLine("\nOm du får mer än 21 poäng har du förlorat. \nBåde du och datorn får två kort i början. Därefter får du dra fler kort tills du är nöjd eller får över 21. \n\nTryck på en knapp för att visa att du har förstått");
          Console.ReadLine();

          Console.WriteLine("\nNär du är färdig drar datorn kort till den har mer poäng än dig eller över 21 poäng. Det är alla regler. Detta är början till din Blackjack mästeri");
          break;
        case 3:
          Console.WriteLine("Visa den senaste vinnaren");
          Console.WriteLine("\nIngen har vunnit över roboten :3");
          break;
        case 4:
          Console.WriteLine("Då va det slut!");
          break;

        default:
          Console.WriteLine("Ej giltig kommando");
          break;
      }
    }
  }
}
