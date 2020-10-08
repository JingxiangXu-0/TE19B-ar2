using System;

namespace Uppgift_4_10
{
  class Program
  {
    static void Main(string[] args)
    {
      for (int siffra = 1; siffra < 31; siffra++)
      {
        if (siffra % 4 == 0)
        {
          continue;
        }
        Console.WriteLine(siffra);
      }
    }
  }
}
