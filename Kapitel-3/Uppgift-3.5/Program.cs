// För att få åka en viss berg-och-dalbana på en nöjespark så måste man vara mellan 1,5 och 1,9 meter lång. Skapa ett program som frågar användaren hur lång hen är och sedan skriver ut om hen får åka berg-och-dalbanan eller inte.
using System;

namespace Uppgift_3._5
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hur lång är du?");
      double längd = double.Parse(Console.ReadLine());

      if (längd <= 1.9 && längd >= 1.5)
      {
        Console.Write("Du får åka berg-och-dalbana! :)");
      }
      else
      {
        Console.Write("Du får inte åka! :)");
      }
    }
  }
}
