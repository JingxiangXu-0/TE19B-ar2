using System;
using System.IO;

namespace Filhantering
{
  class Program
  {
    static void Main(string[] args)
    {
      // skriv en textfil
      File.WriteAllText("fil1.txt", "Nu snöar det igen! KUL!");

      string allText = File.ReadAllText("./Filhantering.csproj");

      Console.WriteLine($"Innehållet: \n{allText}");


      Console.WriteLine($"Ange filnamn:");
      string filnamn = Console.ReadLine();


      if (File.Exists(filnamn))
      {
        string texten = File.ReadAllText(filnamn);
        Console.WriteLine(texten);
      }
      else
      {
        Console.WriteLine($"Hittade inte filen \"(filen)");
      }
    }
  }
}