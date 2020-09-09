using System;

namespace Konsolen
{
  class Program
  {
    static void Main(string[] args)
    {
      // Ge färg till terminalens backgrund
      Console.BackgroundColor = ConsoleColor.Cyan;

      // Ändra textfärg i terminalen
      Console.ForegroundColor = ConsoleColor.DarkMagenta;

      Console.WriteLine("Ya boi!");
    }
  }
}
