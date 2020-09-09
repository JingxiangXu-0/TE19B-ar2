using System;

namespace Exempel_1
{
  class Program
  {
    static void Main(string[] args)
    {
      // Deklarera en variabel för namnet
      string name = "";
      string hobby = "";
      string meddelande = "";

      // Läser in namnet
      Console.Write("Vad Heter Du? ");
      name = Console.ReadLine();

      //Läser in hobby
      Console.Write("Vad har du för hobby? ");
      hobby = Console.ReadLine();

      // Sätter samman meddelandet
      meddelande = "Hej " + name + "!" + " Jag vet att du gillar att " + hobby + "  :)";

      // Skrver meddelandet
      Console.WriteLine(meddelande);
    }
  }
}
