﻿using System.Security.Cryptography.X509Certificates;

namespace _11_12_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            ////num array
            //int[] numberArray;
            //numberArray = new int[3];

            //numberArray[0] = 10;
            //numberArray[1] = 20;
            //numberArray[2] = 30;

            //string[] numberArrayToString;
            //numberArrayToString = new string[3];

            ////text array
            //string[] stringArray = new string[3];

            //stringArray[0] = "aahhh1";
            //stringArray[1] = "aahhh2";
            //stringArray[2] = "aahhh3";

            //int[] anotherNumArray = { 5, 15, 25, 35, 45 };

            //numberArrayToString[0] = numberArray[0].ToString();
            //numberArrayToString[1] = numberArray[1].ToString();
            //numberArrayToString[2] = numberArray[2].ToString();

            //Console.WriteLine(numberArrayToString[0] + " ahh " + numberArrayToString[1] +" ahh "+ numberArrayToString[2]);
            //Console.WriteLine(stringArray[0] + " ahh " + stringArray[1] + " ahh " + stringArray[2]);

            #endregion

            #region Q2
            string[] playerNames = new string[4];
            int playerNum = 0;

            int[] diceRoll = new int[4];

            int highestNum = 0;
            string highestPlayer = "test";

            //var playerNumber = new (int, string)[4];

            //foreach (var item in playerNames) 
            //{
            //    playerNum++;
            //    Console.WriteLine("player " + playerNum + " enter your name: ");
            //    playerNames[playerNum - 1] = Console.ReadLine();
            //    Console.Write("player name saved");
            //    Console.WriteLine();
            //    Console.WriteLine();
            //    if (playerNum == 4)
            //{
            //    Console.WriteLine("the player names are:");
            //    Console.WriteLine("player 1: " + playerNames[0]);
            //    Console.WriteLine("player 2: " + playerNames[1]);
            //    Console.WriteLine("player 3: " + playerNames[2]);
            //    Console.WriteLine("player 4: " + playerNames[3]);
            //}
            //}

            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("player " + i + " enter your name: ");
                playerNames[i - 1] = Console.ReadLine();
                Console.WriteLine();
                //if (i == 4)
                //{
                //    Console.WriteLine("the player names are:");
                //    Console.WriteLine("player 1: " + playerNames[0]);
                //    Console.WriteLine("player 2: " + playerNames[1]);
                //    Console.WriteLine("player 3: " + playerNames[2]);
                //    Console.WriteLine("player 4: " + playerNames[3]);
                //}
            }

            #endregion

            #region Q3
            Console.WriteLine();
            foreach (var item in playerNames) 
            {
                playerNum++;
                Random random = new Random();
                diceRoll[playerNum - 1] = random.Next(1, 100);
                Console.WriteLine(playerNames[playerNum - 1] + " rolled: " + diceRoll[playerNum - 1]);

                if (highestNum > diceRoll[playerNum - 1])
                {
                    highestNum = diceRoll[playerNum - 1];
                    highestPlayer = playerNames[playerNum - 1];
                }
                //playerNumber[playerNum - 1].Item2 = playerNames[playerNum - 1];
                //playerNumber[playerNum - 1].Item1 = diceRoll[playerNum - 1];
            }
            #endregion

            
            //highestNum = playerNumber.Max().Item1;
            Console.WriteLine("highest number is: " + highestNum);
            Console.WriteLine("winner is: " + highestPlayer);

        }
    }
}