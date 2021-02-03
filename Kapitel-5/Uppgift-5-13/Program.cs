using System;

namespace Uppgift_5._13
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hur många heltal vill du skriva in?");
      int antal = int.Parse(Console.ReadLine());

      int[] talLista = new int[antal];

      for (int i = 0; i < antal; i++)
      {
        Console.WriteLine("Skriv in ett heltal");
        talLista[i] = int.Parse(Console.ReadLine());
      }

      Random slump = new Random();
      int index = slump.Next(0, talLista.Length);

      Console.WriteLine($"Talet med index {index} har värdet {talLista[index]}");

    }
  }
}