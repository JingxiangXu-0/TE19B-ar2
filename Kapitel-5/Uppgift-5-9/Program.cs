using System;

namespace Uppgift_5_9
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Skriv en beräkning med plustecken");
      string mening = Console.ReadLine();

      string[] beräkning = mening.Split('+');
      int summan = 0;

      foreach (string termer in beräkning)
      {
        int term = int.Parse(termer);
        summan += term;
      }
      Console.WriteLine("Summan är " + summan);
    }
  }
}
