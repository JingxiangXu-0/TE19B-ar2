using System;

namespace Uppgift_5_4
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] årtal = { 1, 2020, 1, 1982, 1021 };
      Console.WriteLine("Skriv ett årtal");
      int gissning = int.Parse(Console.ReadLine());

      bool finnsÅret = false;
      for (int i = 0; i < årtal.Length; i++)
      {
        if (årtal[i] == gissning)
        {
          finnsÅret = true;
          Console.WriteLine("årtalet finns på index " + i);
        }
      }

      if (finnsÅret == false)
      {
        Console.WriteLine("Årtalet du skrev in fanns inte i arrayen");
      }

    }
  }
}
