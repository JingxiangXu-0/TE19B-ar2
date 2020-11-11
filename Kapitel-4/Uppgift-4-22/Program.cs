using System;

namespace Uppgift_4_22
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Skriv något");
      string med = Console.ReadLine();
      Console.WriteLine("Skriv antal steg åt höger");
      int steg = int.Parse(Console.ReadLine());

      for (int i = 0; i < med.Length; i++)
      {
        for (int j = 0; j < steg; j++)
        {
          Console.WriteLine(" ");
        }
        Console.WriteLine(med[i]);
      }
    }
  }
}
