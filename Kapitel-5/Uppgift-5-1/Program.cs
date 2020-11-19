using System;

namespace Uppgift_5_1
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] städer = new string[3];

      städer[0] = "Stockholm";
      städer[1] = "Göteborg";
      Console.WriteLine("Skriv en annan svensk stad som inte är " + städer[0] + " eller " + städer[1]);
      städer[2] = Console.ReadLine();

      Console.WriteLine("Här är tre svenska städerna: " + städer[0] + " " + städer[1] + " och " + städer[2]);

    }
  }
}
