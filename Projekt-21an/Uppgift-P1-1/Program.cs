using System;

namespace Uppgift_P1_1
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Välj ett tal mellan 1-10");

      int gissning = 0;
      string input = Console.ReadLine();

      if (int.TryParse(input, out gissning))
      {
      }
      else
      {
        Console.WriteLine("Ingen Tal = :(");
      }

      Random random = new Random();
      int rng = random.Next(1, 11);

      if (gissning == rng)
      {
        Console.WriteLine("Du har gissat rätt!");
      }
      else
      {
        Console.WriteLine("Du har gissat fel! Det rätta svaret är " + rng);
      }
    }
  }
}
