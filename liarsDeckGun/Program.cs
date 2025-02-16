using System;

namespace liarsDeckGun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] guns = new int[] { 0, 0, 0, 0 };
            int staticPlayerAmount;
            int playerAmount;
            int playerGettingShot;

            Console.WriteLine("How many players are there? (min two, max four players)");
            Loop1();

            void Loop1()
            {
                playerAmount = ReadIntInput();
                staticPlayerAmount = playerAmount;
                if (playerAmount > 4 || playerAmount < 2)
                {
                    Console.WriteLine("There can only be Two to Four players. Please fill in a valid integer.");
                    Loop1();
                    return;
                }
                for (int i = 0; i < playerAmount; i++)
                {
                    Random rnd = new Random();
                    int random = rnd.Next(1, 7);
                    guns[i] = random;
                }
                Console.Clear();
                Console.WriteLine("Player amount registered, guns loaded.");
                Console.WriteLine("Assign every player a different number from 1 to " + playerAmount);
                Console.WriteLine("When a player loses a match, Enter their number into the console and press enter.");
                Loop2();
            }
            void Loop2()
            {
                playerGettingShot = ReadIntInput();
                if (playerGettingShot > staticPlayerAmount || playerGettingShot < 1)
                {
                    Console.WriteLine("There are " + staticPlayerAmount + " players. Please fill in a valid integer.");
                    Loop2();
                    return;
                }
                guns[playerGettingShot - 1] -= 1;
                if (guns[playerGettingShot - 1] <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Player " + playerGettingShot + " shot themselves");
                    Console.ForegroundColor = ConsoleColor.White;
                    playerAmount -= 1;
                    if (playerAmount > 1)
                    {
                        Console.WriteLine(playerAmount + " players left.");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("When a player loses a match, Enter their number into the console and press enter.");
                        Loop2();
                    } else
                    {
                        Console.WriteLine("1 player left.");
                        for (int i = 0;i < guns.Length; i++)
                        {
                            if (guns[i] > 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Player " + (i+1) + " wins.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                    }
                }   
                else
                {
                    Console.WriteLine("Player " + playerGettingShot + " lives");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("When a player loses a match, Enter their number into the console and press enter.");
                    Loop2();
                }
            }


            int ReadIntInput()
            {
                while (true)
                {
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out int result))
                    {
                        return result;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                    }
                }
            }
        }
    }
}