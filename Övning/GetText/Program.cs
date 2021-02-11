using System;

namespace GetText
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] words = new string[5];

      for (int i = 0; i < words.Length; i++)
      {
        Console.WriteLine("Skriv ett ord som är mellan 2 och 7 bokstäver lång.");

        words[i] = Console.ReadLine();
      }

      for (int i = 4; i < words.Length; i--)
      {
        Console.WriteLine(words[i]);
      }

    }
    static int GetText(int min, int max)
    {
      if (min < 2)
      {
        Console.WriteLine("Ordet är för kort");
      }
      else if (max > 7)
      {
        Console.WriteLine("Ordet är för långt");
      }
      else
      {
        Console.WriteLine("NICE");
      }
    }
  }
}
