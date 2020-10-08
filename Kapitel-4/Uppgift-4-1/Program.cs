using System;

namespace Uppgift_4_1
{
  class Program
  {
    static void Main(string[] args)
    {
      int försök = 3;

      while (försök >= 0)
      {
        Console.WriteLine("Vad är 1+1? ");
        int gissning = int.Parse(Console.ReadLine());

        if (gissning != 2)
        {
          Console.WriteLine("Du har fel! Försök igen. Du har " + försök + " kvar.");
          försök--;
        }
        else
        {

          Console.WriteLine("Du har rätt.");
          break;
        }
      }
    }
  }
}
