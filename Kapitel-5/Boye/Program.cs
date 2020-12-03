using System;

namespace Boye
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dikt = {
            "Den mätta dagen, den är aldrig störst.", 
            "Den bästa dagen är en dag av törst.", 
            "Nog finns det mål och mening i vår färd -", 
            "men det är vägen, som är mödan värd.", 
            "Det bästa målet är en nattlång rast,", 
            "där elden tänds och brödet bryts i hast.", 
            "På ställen, där man sover blott en gång,",
            "blir sömnen trygg och drömmen full av sång.", 
            "Bryt upp, bryt upp! Den nya dagen gryr.",
            "Oändligt är vårt stora äventyr.",
            };

                // foreach (var rad in dikt)
                // {
                //   Console.WriteLine(rad);
                // }
                int totalAntalOrd = 0;

                for (int i = 0; i < dikt.Length; i++)
                {
                   if (i % 2 == 0)
                   {
                       System.Console.WriteLine(dikt[i]);
                   }
                   else
                   {
                       System.Console.WriteLine(dikt[i] + "\n");
                   }

                sting[] orden = dikt[i].Split(' ');

                int antalOrd = orden.Length;

                totalAntalOrd += antalOrd;
                }

                System.Console.WriteLine("Antal ord i dikten är " + totalAntalOrd);
        }
    }
}
