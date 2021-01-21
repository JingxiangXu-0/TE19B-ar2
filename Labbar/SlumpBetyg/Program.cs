using System;

namespace SlumpBetyg
{
  class Program
  {
    static void Main(string[] args)
    {
      Random slump = new Random();

      int tal = slump.Next(0, 6);
      Console.WriteLine("slumptal = " + tal);

      if (tal == 0)
      {
        Console.WriteLine("Du fick betyget F");
      }
      if (tal == 1)
      {
        Console.WriteLine("Du fick betyget E");
      }
      if (tal == 2)
      {
        Console.WriteLine("Du fick betyget D");
      }
      if (tal == 3)
      {
        Console.WriteLine("Du fick betyget C");
      }
      if (tal == 4)
      {
        Console.WriteLine("Du fick betyget B");
      }
      if (tal == 5)
      {
        Console.WriteLine("Du fick betyget A");
      }
    }
  }
}
