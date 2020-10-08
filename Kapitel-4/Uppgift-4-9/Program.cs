using System;

namespace Uppgift_4_9
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hur många kvadrattal vill du skriva ut?");
      int antalKvadrater = int.Parse(Console.ReadLine());

      for (int siffra = 1; siffra <= antalKvadrater; siffra++)
      {
        Console.WriteLine(siffra + "*" + siffra + "= " + (siffra * siffra));
      }
    }
  }
}
