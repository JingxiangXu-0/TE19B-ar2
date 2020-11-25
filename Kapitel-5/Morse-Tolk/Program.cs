using System;

namespace Morse_Tolk
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Hejsan! Dent här programmet översätter svenska till morsekod \n\nSkriv ett meddelande: ");
      string meddelande = Console.ReadLine().ToUpper();

      string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ ";
      string[] morsekod = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", ".--", "...-", ".--", "-..-", "-.--", "--..", ".--.-", ".-.-", "---.", " " };
      string morsemeddelande = "";


      for (int i = 0; i < meddelande.Length; i++)
      {
        string bokstav = meddelande[i].ToString();

        int index = alfabetet.IndexOf(bokstav);

        string morseBokstav = morsekod[index];

        morsemeddelande += morseBokstav;
      }

      Console.WriteLine(morsemeddelande);
    }
  }
}
