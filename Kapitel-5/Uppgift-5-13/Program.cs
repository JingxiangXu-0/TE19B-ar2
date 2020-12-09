using System;

namespace Uppgift_5_13
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hur många heltal vill du skriva?");
      int antal = int.Parse(Console.ReadLine());

      int[] Heltaler = new int[antal];

      for (int i = 0; i < antal; i++)
      {
        Console.WriteLine("Skriv in ett heltal");
        Heltaler[i] = int.Parse(Console.ReadLine());
      }

      Random slump = new Random();
      int i = slump.Next(0, Heltaler.Length);

      Console.WriteLine("Talet med index " + i + " har värdet " + Heltaler[slump]);

    }
  }
}
