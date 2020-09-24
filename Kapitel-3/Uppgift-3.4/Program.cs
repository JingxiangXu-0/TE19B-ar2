using System;

namespace Uppgift_3._4
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Vad fick du på NP i Matte 4 våren 2013?");
      int svar = int.Parse(Console.ReadLine());
      if (svar >= 55)
      {
        Console.Write("Du får ett A som betyg");
      }
      else if (svar <= 46 && svar >= 36)
      {
        Console.Write("Du får ett B som betyg");
      }
      else if (svar <= 35 && svar >= 28)
      {
        Console.Write("Du får ett C som betyg");
      }
      else if (svar <= 27 && svar >= 19)
      {
        Console.Write("Du får ett D som betyg");
      }
      else if (svar <= 18 && svar >= 0)
      {
        Console.Write("Du får ett E som betyg");
      }
    }
  }
}
