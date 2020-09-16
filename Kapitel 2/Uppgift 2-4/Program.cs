using System;

namespace Uppgift_2_4
{
  class Program
  {
    static void Main(string[] args)
    {
      int tal1 = int.Parse(args[0]);
      int tal2 = int.Parse(args[1]);

      //   Console.WriteLine("Skriv ett tal!");
      //   double tal1 = double.Parse(Console.ReadLine());

      //   Console.WriteLine("Yani, Skriv ett annat tal!");
      //   double tal2 = double.Parse(Console.ReadLine());

      double summan = tal1 + tal2;
      double produkt = tal1 * tal2;
      Console.WriteLine("Summan av talen är " + summan + " och produkten är " + produkt + "!");
    }
  }
}
