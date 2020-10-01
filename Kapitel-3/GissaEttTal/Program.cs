using System;

namespace GissaEttTal
{
  class Program
  {
    static void Main(string[] args)
    {
      Random random = new Random();
      int randomNummer = random.Next(1, 7);

      for (int i = 0; i < 3; i++)
      {
        Console.WriteLine("Gissa ett tal (1-6)? ");
        int gissning = int.Parse(Console.ReadLine());
        if (gissning == randomNummer)
        {
          Console.WriteLine("Du har rätt!");
          i = 5;
        }
        else
        {
          Console.WriteLine("Du har fel, försök igen");
        }

      }
    }
  }
}
