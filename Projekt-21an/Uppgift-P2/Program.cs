using System;

namespace Uppgift_P2
{
  class Program
  {
    static void Main(string[] args)
    {
      // När användaren startar programmet ska hen få säga hur många tärningar hen vill kasta och hur många sidor varje tärning ska ha
      Console.WriteLine("hur många sidor varje tärning ha");
      int antalSidor = int.Parse(Console.ReadLine());
      Console.WriteLine("och hur många tärningar vill du kasta");
      int antalTärning = int.Parse(Console.ReadLine());
      Random rng = new Random();

      // Simulera därefter det antal tärningskast som användaren vill göra med det antal sidor som användaren valde
      for (int i = 0; i < antalTärning; i++)
      {
        int kast = rng.Next(1, antalSidor + 1);
        Console.WriteLine("Värdet i tärning " + i + " fick siffran " + kast);
      }
    }
  }
}
