using System;
using System.Text;

namespace _2dArray
{
    internal class Program
    {
        const int MapWidth = 10;
        const int MapHeight = 10;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            char[,] grid = new char[MapWidth, MapHeight];
            string characters = "῭΅῞῝῍῎῭΅`ˁ‘‛′ˠꜛ⃰*♣♣♠";
            Random random = new Random();
            //Console.WriteLine(characters[2]);

            // Fill the array
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    // Select a random index from the characters string
                    // so make an integer
                    // give it a random value between 0 and characters.Length
                    // Fill your array with a random value from that string;
                    // something like grid[x, y] = characters[RANDOM NUMBER]

                    int rnd = random.Next(0, characters.Length);
                    grid[i, j] = characters[rnd];
                }
            }

            // Print the array
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Console.Write(grid[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
//while (true)
//{
//    for (int x = 0; x < MapWidth; x++)
//    {
//        for (int y = 0; y < MapHeight; y++)
//        {
//            CoordinateArray[x, y] = $"[{x},{y}]";
//        }
//    }

//    for (int x = 0; x < MapWidth; x++)
//    {
//        for (int y = 0; y < MapHeight; y++)
//        {
//            Console.WriteLine(CoordinateArray[x, y]);
//            Thread.Sleep(150);
//        }
//        Console.WriteLine();
//    }
//}
