using System;

namespace Projekt_1
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.ForegroundColor = ConsoleColor.Cyan;

      Console.WriteLine("Eyy bror, jag har baxat chok mycket parra igår, ska vi beställa kebab? Jag är chok hungrig mannen.");

      string Svar1 = Console.ReadLine().ToLower();

      if (Svar1 == "ja")
      {
        Console.WriteLine("Yani, Vill du dricka något?");
        Svar2();
      }

      if (Svar1 == "nej")
      {
        Console.WriteLine("Yani, är du inte hungrig? WALLAH jag ska äta upp allt själv då.");
      }

      Console.ReadLine();

    }
    static void Svar2()
    {
      string Svar2;
      Svar2 = Console.ReadLine().ToLower();

      if (Svar2 == "ja")
      {
        Console.WriteLine("Ait bror, vill du en cola?");
        svar3();
      }

      if (Svar2 == "nej")
      {
        Console.WriteLine("Ait, maten kommer om 20 min.");
      }

      Console.ReadLine();

    }
    static void svar3()
    {
      string Svar3;
      Svar3 = Console.ReadLine().ToLower();

      if (Svar3 == "nej")
      {
        Console.WriteLine("Yani, vad vill du dricka? De har bara fanta, cola och sprite.");
        dricka();
      }

      if (Svar3 == "ja")
      {
        Console.WriteLine("Ait bror, jag har beställt klart. Maten är här om 20 minuter.");
      }

      Console.ReadLine();

    }
    static void dricka()
    {

      string Svar4;
      Svar4 = Console.ReadLine().ToLower();

      if (Svar4 == "fanta")
      {
        Console.WriteLine("Ait bror, jag har beställt en fanta till dig. Maten är här om 20 minuter");
      }

      if (Svar4 == "cola")
      {
        Console.WriteLine("bror bestäm dig, jag kommer då beställa en cola till dig. Maten är här om 20 minuter");
      }

      else if (Svar4 == "sprite")
      {
        Console.WriteLine("Ait bror, jag har beställt sprite till dig. Maten är här om 20 minuter");
      }

      Console.ReadLine();
    }
  }
}

