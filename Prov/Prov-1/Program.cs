using System;

namespace Prov_1
{
  class Program
  {
    static void Main(string[] args)
    {
    Start:
      int val = 0;

      Console.WriteLine("Det här programmet räknar ut din lön, sk nettolön, efter marginalskatten. Marginalskatten räknas ut baserat på din bruttolön. Med bruttolön avses din årslön före skatt.");

      Console.Write("Ange ditt namn: ");
      string namn = Console.ReadLine();

      Console.WriteLine("\nHejsan " + namn + "! Välkommen Till Menyn!");

      while (val != 1)
      {
        Console.WriteLine("Välj ett av alternativen.");
        Console.WriteLine("1. Starta Programmet");
        Console.WriteLine("2. Avsluta programmet");
        Console.Write("Jag väljer alternativ : ");
        val = int.Parse(Console.ReadLine());
        break;
      }

      switch (val)
      {
        case 1:
          Console.Write("Ange din bruttolön i kronor: ");
          int bruttolön = int.Parse(Console.ReadLine());
          double marginaltal = 0;
          double nettolön = 0;

          if (bruttolön < 10000 && bruttolön > 0)
          {
            marginaltal = 8;
          }

          else if (bruttolön <= 0)
          {
            Console.WriteLine("Bruttolön måste vara > 0 kr!");
            break;
          }
          else if (bruttolön >= 10000 && bruttolön < 145000)
          {
            marginaltal = 22;
          }
          else if (bruttolön < 515000 && bruttolön >= 145000)
          {
            marginaltal = 33;
          }
          else if (bruttolön >= 515000)
          {
            marginaltal = 53;
          }

          nettolön = bruttolön * (100 - marginaltal) / 100;

          Console.WriteLine(namn + ", Din nettolön blir " + nettolön + " kr och marginalskatten " + marginaltal + "%.");
          Console.WriteLine("Tryck på 1 ifall du vill göra en ny beräkning.");
          int svar = int.Parse(Console.ReadLine());

          if (svar == 1)
          {
            Console.WriteLine("oki, då börjar vi om programmet :)");
            goto Start;
          }
          else
          {
            Console.WriteLine("Då va det slut!");
            break;
          }

        case 2:
          Console.WriteLine("Då va det slut!");
          break;

        default:
          Console.WriteLine("Välj ett av anternativet!");
          goto Start;
      }
    }
  }
}
