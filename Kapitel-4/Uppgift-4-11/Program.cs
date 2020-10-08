using System;

namespace Uppgift_4_11
{
  class Program
  {
    static void Main(string[] args)
    {
      int försök = 5;

      while (försök >= 0)
      {
        Console.WriteLine("Vilket är Europas folkrikaste land? ");
        string svar = Console.ReadLine();
        svar = svar.ToLower();

        if (svar != "tyskland")
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
