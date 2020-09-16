using System;

namespace Uppgift_2_5
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Vilket år är det?");
      double årNu = double.Parse(Console.ReadLine());

      double årKvar = 2100 - årNu;
      Console.WriteLine("Det är " + årKvar + " kvar tills det blir år 2100. :)");
    }
  }
}
