// Skapa ett program där användaren på endast en rad ska skriva in en addition av två heltal som ska utföras . Användaren ska inte skriva några mellanslag, t.ex. kan hen skriva 4+3 eller 10+27. Beräkna svaret och skriv ut det.
using System;

namespace Uppgift_2_8
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Skriv en addition");
      string addition = Console.ReadLine();
      int plus = addition.IndexOf("+");
      string tal1 = addition.Substring(0, plus);
      string tal2 = addition.Substring(plus + 1);
      int term1 = int.Parse(tal1);
      int term2 = int.Parse(tal2);
      int summan = term1 + term2;

      Console.WriteLine(addition + " = " + summan);

    }
  }
}
