using System;

namespace Uppgift_5_6
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("skriv 5 städer");

      string[] städer = new string[5];

      for (int i = 0; i < städer.Length; i++)
      {
        Console.WriteLine("Skriv in stad " + i);
        städer[i] = Console.ReadLine();
      }

      Console.WriteLine("De städer du skrev in är");

      foreach (string stad in städer)
      {
        Console.WriteLine(stad);
      }
    }
  }
}
