using System;

namespace Uppgift_5_7
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] tal = { 123, -123, 123, 123, 643 };

      int summa = 0;


      foreach (int term in tal)
      {
        summa += term;
      }
      System.Console.WriteLine("summan av talen är " + summa);


    }
  }
}
