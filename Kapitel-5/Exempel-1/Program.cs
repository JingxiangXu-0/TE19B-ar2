using System;

namespace Exempel_1
{
  class Program
  {
    static void Main(string[] args)
    {
      // Alt 1:
      // Array på 3 strings
      string[] städer = { "Stockholm", "Oslo", "London" }; //Låst till 3st!

      //   Skriver ut innehåler
      städer[0] = "Stockholm"; //index = 0
      städer[1] = "Oslo"; //index = 1
      städer[2] = "London"; //index = 2

      // Alt 2: Skapa en tom array på 2 strings
      string[] länder = new string[2];
      länder[0] = "Sverige";
      länder[1] = "Frankrike";


      //   Skapa en array med int
      int[] årtal = new int[3];
      // årtal[0] = "1945";
      // årtal[1] = "1997";
      // årtal[2] = "2018";

    }
  }
}
