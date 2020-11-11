using System;

namespace Uppgift_4_23
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Skriv ett ord");
      string text = Console.ReadLine();
      Console.WriteLine("Skriv bara två tecken");
      string tecken = Console.ReadLine();

      bool tecken1 = false;
      bool tecken2 = false;

      for (int i = 0; i < text.Length; i++)
      {
        if (text[i] == tecken[0])
        {
          tecken1 = true;
        }
        if (text[i] == tecken[1])
        {
          tecken2 = true;
        }
      }

      if (tecken1 && tecken2)
      {
        Console.WriteLine("Båda tecknen finns i den första strängen");
      }
      else
      {
        Console.WriteLine("Ett av tecknen finns i den första strängen");
      }
    }
  }
}
