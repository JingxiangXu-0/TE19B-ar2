using System;

namespace Uppgift_4_6
{
  class Program
  {
    static void Main(string[] args)
    {
      // Meddelandet
      string med = "Hello World!";

      // Att få meddelandet att skrivas ut vertikalt och baklänges.
      for (int i = med.Length - 1; i >= 0; i--)
      {
        Console.WriteLine(med[i]);
      }
    }
  }
}
