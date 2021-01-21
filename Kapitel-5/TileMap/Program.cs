using System;

namespace TileMap
{
    class Program
    {
        static void Main(string[] args)
        {
// skapa en karta
        int[,] labyrint = {
        {1, 1, 2, 2, 2, 2, 1, 1},
        {0, 0, 0, 0, 1, 2, 1, 1},
        {1, 1, 0, 1, 1, 2, 1, 1},
        {1, 1, 0, 0, 1, 1, 1, 1},
        {2, 2, 1, 0, 1, 1, 1, 1},
        {1, 2, 1, 0, 0, 0, 1, 1},
        {1, 2, 1, 1, 1, 0, 1, 1},
        {2, 2, 1, 1, 1, 0, 0, 0},
        };

Console.OutputEncoding = System.Text.Encoding.Default;

        for (int y = 0; y < 8; y++)
        {
           for (int x = 0; x < 8; x++)
           {

if (labyrint[y, x] == 1)
{
   Console.Write('\u2B1C');    
}   
else if (labyrint[y, x] == 2)
{
    Console.Write('\u2B15');
}
else
{
    Console.Write('\u2B1B');
}     

}
               Console.WriteLine();
            }
        }        
    }
}