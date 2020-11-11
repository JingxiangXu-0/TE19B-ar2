using System;

namespace Uppgift_4_13
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("vilken höjd och breed?");
      int breed = int.Parse(Console.ReadLine());
      int höjd = int.Parse(Console.ReadLine());
      {
        for (int y = 0; y < 5; y++)
        {
          for (int x = 0; x < 7; x++)
          {
            if (y == 0 || y == 4 || x == 0 || x == 6)
            {
              Console.Write("X");
            }
            else if (x <= 6)
            {
              Console.Write(" ");
            }
          }
          Console.WriteLine();
        }
      }
    }
  }
}