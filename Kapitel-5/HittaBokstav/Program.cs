using System;

namespace HittaBokstav
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Skriv något snälla, jag vill inte dö.: ");
      string bokstav = Console.ReadLine().ToUpper();

      string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ ";
      string[] morsekod = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", ".--", "...-", ".--", "-..-", "-.--", "--..", ".--.-", ".-.-", "---.", " " };


      int index = alfabetet.IndexOf(bokstav);

      string morseBokstav = morsekod[index];

      Console.WriteLine("morsekoden är " + morseBokstav);
    }
  }
}