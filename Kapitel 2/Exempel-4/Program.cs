using System;

namespace Exempel_4
{
  class Program
  {
    static void Main(string[] args)
    {
      //en fallgrop när man räknar heltal.
      double delat1 = 7 / 2;
      Console.WriteLine("delat = " + delat1);

      double delat2 = (double)7 / 2;
      Console.WriteLine("delat = " + delat2);

      double delat3 = 7 / 2d;
      Console.WriteLine("delat = " + delat3);

      double delat4 = 7.0 / 2;
      Console.WriteLine("delat = " + delat4);

      float delat5 = 7f / 2;
      Console.WriteLine("delat = " + delat5);

      // Läs in epost-adress
      Console.Write("Ange en email: ");
      string email = Console.ReadLine();

      // Leta efter ett texken i en text
      int position = email.IndexOf("@");
      Console.WriteLine("@ ligger på en position = " + position);

      //   Plocka namn
      string namn = email.Substring(0, position); //plockar 0 -> position
      Console.WriteLine("namndelen = " + namn);

      //   Plocka domän
      string domän = email.Substring(position + 1); // Från position + 1 -> slut
      Console.WriteLine("domän = " + domän);

    }
  }
}
