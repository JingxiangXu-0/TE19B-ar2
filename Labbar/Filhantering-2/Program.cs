using System;
using System.IO;

namespace Filhantering_2
{
  class Program
  {
    static void Main(string[] args)
    {
      string filnamn = "./animals.txt";

      string[] rader = File.ReadAllLines(filnamn);

      int antal = 1;
      foreach (var rad in rader)
      {
        if (rad.substring(0, 1) == sök)
        {
          console.writelinte()
        }
        Console.WriteLine(antal + "" + rad);
        antal++;
      }

      Console.WriteLine($"hittade {antal - 1} djur");
    }
  }
}
