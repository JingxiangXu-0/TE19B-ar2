using System;

namespace Expert10000
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.WriteLine("Hur många timmar vill du träna per dag?");

      string svar = Console.ReadLine();
      double timmarPerdag = 0;
      //   Kontreollera att användaren matar in ett tal
      while (!double.TryParse(svar, out timmarPerdag) && timmarPerdag <= 0)
      {
        Console.Write("Ogiltigt input, försök igen!");
        svar = Console.ReadLine();
      }

      // Räkna ut när man blir klar
      DateTime datumKlar = DateTime.Today.AddDays(10000 / timmarPerdag);
      TimeSpan hurLångTid = datumKlar - DateTime.Today;

      int antalÅr = hurLångTid.Days / 365;
      Console.WriteLine("Du måste träna i " + antalÅr + " år mao är du klar år " + datumKlar);
    }
  }
}
