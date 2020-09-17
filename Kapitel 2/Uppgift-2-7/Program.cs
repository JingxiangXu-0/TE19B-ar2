// Skapa ett program där användaren får skriva in en mening (utan punkt) som består av två ord. Skriv ut orden till användaren i omvänd ordning.

using System;

namespace Uppgift_2_7
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Skriv en mening som består av två ord");

      string mening = Console.ReadLine();
      int mellan = mening.IndexOf(" ");
      string ord1 = mening.Substring(0, mellan);
      string ord2 = mening.Substring(mellan + 1);

      Console.WriteLine(ord2 + " " + ord1);
    }
  }
}
