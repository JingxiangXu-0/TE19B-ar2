using System;

namespace Exempel_5
{
  class Program
  {
    static void Main(string[] args)
    {
      string namn = "Jing";
      Console.WriteLine("Hello! " + namn);
      //  Med hjälp av vaiabelsubsition
      Console.WriteLine($"Hello  {namn}");

      string svar = $"mitt förnamn är {namn}.";
      Console.WriteLine(svar);
    }
  }
}
