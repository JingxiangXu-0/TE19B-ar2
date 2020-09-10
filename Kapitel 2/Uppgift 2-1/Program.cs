using System;

namespace Uppgift_2._1
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hur många meter kan du hoppa i höjdhopp?");

      double minHopp = double.Parse(Console.ReadLine());
      double skillnaden = 2.45 - minHopp;

      Console.WriteLine("Hej, världsrekordet är " + skillnaden + " meter högre. ya suck");
    }
  }
}