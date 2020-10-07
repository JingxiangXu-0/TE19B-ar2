using System;

namespace Exempel_1
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
        int gissning = int.Parse(Console.ReadLine());


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
