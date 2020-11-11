using System;

namespace Exempel_4
{
  class Program
  {
    static void Main(string[] args)
    {
      Random random = new Random();
      int randomNummer = random.Next(1, 7);
      int försök = 3;

      while (försök >= 0)
      {
        Console.WriteLine("Gissa ett tal (1-6)? ");
        int gissning = 0;

        string input = Console.ReadLine();

        if (int.TryParse(input, out gissning))
        {
          Console.WriteLine("Tal = :)");
          Console.WriteLine("");
        }
        else
        {
          Console.WriteLine("Ingen Tal = :(");
          Console.WriteLine("");
        }

        if (gissning == randomNummer)
        {
          Console.WriteLine("Du har rätt!");
          break;
        }
        else
        {
          Console.WriteLine("Du har fel! Försök igen. Du har " + försök + " kvar.");
          försök--;
        }
      }
    }
  }
}