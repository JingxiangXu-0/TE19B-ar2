using System;
using System.IO;

namespace Projekt_2
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] bordsInformation;
      string filnamn = "jingsbord.txt";
      string tomtBordBeskrivning = "0;Inga gäster";
      int antalbord = 5;

      Console.WriteLine("Detta är Jings bordshanterare\nBordsinformation lästes in från fil");

      // kollar om filen finns
      if (File.Exists(filnamn))
      {
        string bordsInnehåll = File.ReadAllText(filnamn);
        Console.WriteLine("Här är Bords infromationen:");
        Console.WriteLine(bordsInnehåll);
      }
      else //om filen inte finns, skapas en ny fil
      {
        bordsInformation = new string[antalbord];
        for (int i = 0; i < bordsInformation.Length; i++)
        {
          bordsInformation[i] = tomtBordBeskrivning;
        }
        File.WriteAllLines(filnamn, bordsInformation);
        Console.WriteLine("Fil med bordsinformation fanns ej så ny fil skapades");
      }
      Console.WriteLine();

      //  Programmets Meny

      int menuVal = 0;
      while (menuVal != 4)
      {
        Console.WriteLine("Välj ett av alternativen.");
        Console.WriteLine("1. Visa alla bord");
        Console.WriteLine("2. Lägg ändra bordsinformation");
        Console.WriteLine("3. Markera att ett bord är tomt");
        Console.WriteLine("4. Avsluta programmet");
        Console.Write("Jag väljer alternativ : ");
        menuVal = int.Parse(Console.ReadLine());
        break;
      }

      switch (menuVal)
      {
        case 1:
          // om det är inte personer i ett bord
          int totaltAntalGäster = 0;

          for (int i = 0; i < bordsInformation.Length; i++)
          {
            if (bordsInformation[i] == tomtBordBeskrivning)
            {
              Console.WriteLine($"Bord {i + 1} - Inga gäster");
              continue;
            }
            // om det är personer vid ett bord
            string[] speciellBordsinformation = bordsInformation[i].Split(';');
            int antalGäster = int.Parse(speciellBordsinformation[0]);
            string bordsnamn = speciellBordsinformation[1];
            totaltAntalGäster += antalGäster;
            Console.WriteLine($"Bord {i + 1} - Namn: {bordsnamn}, Antal gäster: {antalGäster}");

          }
          Console.WriteLine($"Totalt antal gäster: {totaltAntalGäster}");
          break;

        case 2:
          Console.WriteLine("Vilket bordsnummer vill du lägga till/ändra informationen för?");
          int ändraBordsnummer = int.Parse(Console.ReadLine());

          while (ändraBordsnummer <= 0 || ändraBordsnummer > bordsInformation.Length)
          {
            Console.WriteLine($"{ändraBordsnummer} är inte ett giltigt bordsnummer. Försök igen.");
            break;
          }

          Console.WriteLine("Skriv in bordets namn");
          string bordsNamn = Console.ReadLine();
          Console.WriteLine("Hur många gäster finns vid bordet?");
          int antalGäster = int.Parse(Console.ReadLine());
          break;

        case 3:

          break;

        case 4:
          Console.WriteLine("Hejdå!");
          break;

        default:
          Console.WriteLine("error");
          break;
      }
    }
  }
}

