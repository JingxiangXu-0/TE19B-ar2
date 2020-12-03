using System;

namespace Uppgift_5_12
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] meningar = { "dskfjkldsf", "asddfölgldfgkl", "sdkfjsdlfsdj", "sdjfklsdfjsdl", "ofdkoqweknsd" };

      foreach (var rad in meningar)
      {
        System.Console.WriteLine(rad + "\n");
      }
    }
  }
}
