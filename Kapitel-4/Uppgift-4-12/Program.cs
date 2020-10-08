using System;

namespace Uppgift_4_12
{
  class Program
  {
    static void Main(string[] args)
    {
      for (int y = 1; y < 7; y++)
      {
        for (int x = 1; x < 7; x++)
        {
          Console.Write(" " + x * y);
        }
        Console.WriteLine();
      }
    }
  }
}
