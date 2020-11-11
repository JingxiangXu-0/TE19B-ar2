using System;

namespace Uppgift_4_7
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Skriv ett tal");
      string tal = Console.ReadLine();

      int summan = 0;
      for (int i = 0; i < tal.Length; i++)
      {
        string tecken = tal[i].ToString();
        int siffra = int.Parse(tecken);
        summan += siffra;
      }
      Console.WriteLine("Siffersumman av talet " + tal + " är " + summan);
    }
  }
}
