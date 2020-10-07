using System;

namespace Exempel_1_2
{
  class Program
  {
    static void Main(string[] args)
    {
      int val = 0;

      while (val != 3)
      {
        Console.WriteLine("\nVälj ett av alternativen.");
        Console.WriteLine("1. Addera två tal");
        Console.WriteLine("2. Multiplicera två tal");
        Console.WriteLine("3. Avsluta programmet");
        Console.Write("Jag väljer alternativ : ");
        break;
      }

      val = int.Parse(Console.ReadLine());

      switch (val)
      {
        case 1:
          Console.WriteLine("Addera talen = ");
          Double tal1 = double.Parse(Console.ReadLine());
          Double tal2 = double.Parse(Console.ReadLine());
          Console.WriteLine(tal1 + " + " + tal2 + " = " + (tal1 + tal2));
          break;

        case 2:
          Console.WriteLine("multiplicera talen = ");
          Double faktor1 = double.Parse(Console.ReadLine());
          Double faktor2 = double.Parse(Console.ReadLine());
          Console.WriteLine(faktor1 + " * " + faktor2 + " = " + (faktor1 * faktor2));
          break;


        case 3:
          Console.WriteLine("Byeee");
          break;

        default:
          Console.Write("Error");
          break;
      }
    }
  }
}
