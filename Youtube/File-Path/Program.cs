using System;
using System.IO;

namespace File_Path
{
  class Program
  {
    static void Main(string[] args)
    {

      string filePath = @"C:\Demos\Test.txt";
      // string[] lines = File.ReadAllLines(filePath);

      // Jobbigt att jobba med arrays så man kan använda list istället

      List<string> lines = File.ReadAllText(filePath).toList();

      foreach (string line in lines)
      {
        Console.WriteLine(line);
      }
      lines.Add("Sue, Storm, www.Storm.com");

      File.WriteAllText(filepath, lines);

      Console.ReadLine();

      // han använde clash? förstår inte har sökt men hittar inte vad jag ska göra, ska jobba på bordhantering istället.
    }
  }
}
