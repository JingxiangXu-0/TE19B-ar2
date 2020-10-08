using System;

namespace Uppgift_4_3
{
  class Program
  {
    static void Main(string[] args)
    {
      int val = 0;

      while (val != 3)
      {
        Console.WriteLine("\nVälj ett av alternativen.");
        Console.WriteLine("1. Omvandla meter till kilometer");
        Console.WriteLine("2. Omvandla kilometer till meter");
        Console.WriteLine("3. Avsluta programmet");
        Console.Write("Jag väljer alternativ : ");
        break;
      }

      val = int.Parse(Console.ReadLine());

      switch (val)
      {
        case 1:
          Console.WriteLine("Skriv in en längd i meter");
          double Meter = double.Parse(Console.ReadLine());
          Console.WriteLine("Längden du skrev in är " + Meter / 1000 + " km.");
          break;

        case 2:
          Console.WriteLine("Skriv in en längd i km");
          double Km = double.Parse(Console.ReadLine());
          Console.WriteLine("Längden du skrev in är " + Km * 1000 + " meter");
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
