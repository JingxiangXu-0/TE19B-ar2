using System;

namespace CeasarKrypto
{
  class Program
  {
    static void Main(string[] args)
    {
      // ange en text
      Console.WriteLine("Hello! Ange en text:");
      string text = Console.ReadLine();
      Console.WriteLine("Skriv ett tal mellan 1-9: ");
      string valfrittstring = Console.ReadLine();

      // Säkerställa att man får in ett tal
      int valfritt = 0;

      while (!int.TryParse(valfrittstring, out valfritt))
      {
        Console.WriteLine("Skriv en siffra, skriv igen");
        valfrittstring = Console.ReadLine();
      }

      // loopa igenom inmatad texten bokstav för bokstav
      int textLängd = text.Length;
      Console.WriteLine("Texten är + " + textLängd + " tecken lång.");

      // loopa igenom inmatad texten bokstav för bokstav
      string krypteradText = "";
      for (int i = 0; i < textLängd; i++)
      {
        Console.WriteLine("loop nr " + i);
        // Plocka ut bokstav på position i
        Char bokstav = text[i];
        Console.WriteLine("bokstaven på position " + i + " är " + bokstav);

        // Ascii-värdet för ett tecken
        int ascii = (int)bokstav;
        Console.WriteLine("bokstaven " + bokstav + "har Ascii-värdet " + ascii);

        // ceasarkryptering
        ascii += valfritt;

        // Plocka it motsvarande tecken enligt ascii tabellen
        char krypteradBokstav = (char)ascii;
        Console.WriteLine("bokstaven " + bokstav + " krypteras till " + krypteradBokstav);

        // Samla ihop bokstäverna 
        krypteradText += krypteradBokstav.ToString;

        // Skriv ut svaret
        Console.WriteLine("Den slutgiltiga meningen är: " + krypteradText);
      }
    }
  }
}
