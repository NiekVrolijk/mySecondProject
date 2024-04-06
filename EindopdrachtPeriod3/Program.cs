using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace EindopdrachtPeriod3
{
    internal class Program
    {
        enum Forest { forest, goblinCamp, weirdShop, ruins }
        static void Main(string[] args)
        {
            Forest forest;
            forest = Forest.forest;

            //inventory
            List<string> inventory = new List<string> { "sword", "chestPlate", "shield" };
            inventory.Sort();

            bool magicSwordPickedUp = false;

            //map
            Console.OutputEncoding = Encoding.UTF8;

            const int MapWidth = 10;
            const int MapHeight = 10;

            char[,] grid = new char[MapWidth, MapHeight];
            string characters = "῭΅῞῝῍῎῭΅`ˁ‘‛′ˠꜛ⃰*♣♣♠";
            Random random = new Random();
            //player position
            int playerY = 4;
            int playerX = 4;

            int playerYBackup = 4;
            int playerXBackup = 4;

            GenerateForestMap();

            //goblin/combat
            //player
            int playerHealth = 9;
            int playerAttack = 1;

            //goblin
            int goblinHealth = 8;
            int goblinAttack = 5;
            bool goblinAlive = true;


            //begin
            CheckLocation();

            void InForest()
            {
                Console.WriteLine("1. look at map");
                Console.WriteLine("2. go North");
                Console.WriteLine("3. go East");
                Console.WriteLine("4. go South");
                Console.WriteLine("5. go West");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //GenerateForestMap();
                        ShowForestMap();
                        Console.WriteLine("what would you like to do?");
                        InForest();
                        break;
                    case 2:
                        Console.WriteLine("how many would you like to go north?");
                        playerYBackup = playerY;
                        playerXBackup = playerX;
                        playerY -= int.Parse(Console.ReadLine());

                        if ((playerY < 1 || playerY > 10) || (playerX < 1 || playerX > 10))
                        {
                            playerX = playerXBackup;
                            playerY = playerYBackup;
                            Console.WriteLine("that is not a choice. What would you like to do?");
                            InForest();
                        }

                        Console.WriteLine($"you are at X: {playerX} and Y: {playerY}");
                        CheckLocation();
                        break;
                    case 3:
                        Console.WriteLine("how many would you like to go east?");
                        playerYBackup = playerY;
                        playerXBackup = playerX;
                        playerX += int.Parse(Console.ReadLine());

                        if ((playerY < 1 || playerY > 10) || (playerX < 1 || playerX > 10))
                        {
                            playerX = playerXBackup;
                            playerY = playerYBackup;
                            Console.WriteLine("that is not a choice. What would you like to do?");
                            InForest();
                        }

                        Console.WriteLine($"you are at X: {playerX} and Y: {playerY}");
                        CheckLocation();
                        break;
                    case 4:
                        Console.WriteLine("how many would you like to go south?");
                        playerYBackup = playerY;
                        playerXBackup = playerX;
                        playerY += int.Parse(Console.ReadLine());

                        if ((playerY < 1 || playerY > 10) || (playerX < 1 || playerX > 10))
                        {
                            playerX = playerXBackup;
                            playerY = playerYBackup;
                            Console.WriteLine("that is not a choice. What would you like to do?");
                            InForest();
                        }

                        Console.WriteLine($"you are at X: {playerX} and Y: {playerY}");
                        CheckLocation();
                        break;
                    case 5:
                        Console.WriteLine("how many would you like to go west?");
                        playerYBackup = playerY;
                        playerXBackup = playerX;
                        playerX -= int.Parse(Console.ReadLine());

                        if ((playerY < 1 || playerY > 10) || (playerX < 1 || playerX > 10))
                        {
                            playerX = playerXBackup;
                            playerY = playerYBackup;
                            Console.WriteLine("that is not a choice. What would you like to do?");
                            InForest();
                        }

                        Console.WriteLine($"you are at X: {playerX} and Y: {playerY}");
                        CheckLocation();
                        break;
                    default:
                        Console.WriteLine("that is not a choice. What would you like to do?");
                        InForest();
                        break;
                }
            }

            void InGoblinCamp()
            {
                if (goblinAlive)
                {
                    Console.WriteLine("1. look at map");
                    Console.WriteLine("2. go North");
                    Console.WriteLine("3. go East");
                    Console.WriteLine("4. go South");
                    Console.WriteLine("5. go West");
                    Console.WriteLine("6. ATTACK");
                    Console.WriteLine("7. DEFEND");
                }
                if (!goblinAlive)
                {
                    Console.WriteLine("1. look at map");
                    Console.WriteLine("2. go North");
                    Console.WriteLine("3. go East");
                    Console.WriteLine("4. go South");
                    Console.WriteLine("5. go West");
                }

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        if (!goblinAlive)
                        {
                            //GenerateForestMap();
                            ShowForestMap();
                            Console.WriteLine("what would you like to do?");
                            InGoblinCamp();
                        }
                        else
                        {
                            //Console.WriteLine("you are in a fight, FIGHT. what would you like to do?");
                            //InGoblinCamp();
                            //GenerateForestMap();
                            ShowForestMap();
                            Console.WriteLine("the goblin took it's change to attack while you where checking your map");
                            playerHealth -= EatDamage();
                            Console.WriteLine($"you have {playerHealth} Health left");
                            Console.WriteLine();
                            Console.WriteLine("what would you like to do?");
                            InGoblinCamp();
                        }
                        break;
                    case 2:
                        if (!goblinAlive)
                        {
                            Console.WriteLine("how many would you like to go north?");
                            playerYBackup = playerY;
                            playerXBackup = playerX;
                            playerY -= int.Parse(Console.ReadLine());

                            if ((playerY < 1 || playerY > 10) || (playerX < 1 || playerX > 10))
                            {
                                playerX = playerXBackup;
                                playerY = playerYBackup;
                                Console.WriteLine("that is not a choice. What would you like to do?");
                                InGoblinCamp();
                            }

                            Console.WriteLine($"you are at X: {playerX} and Y: {playerY}");
                            CheckLocation();
                        } else
                        {
                            //Console.WriteLine("you are in a fight, FIGHT. what would you like to do?");
                            //InGoblinCamp();
                            Console.WriteLine("how many would you like to go north?");
                            playerYBackup = playerY;
                            playerXBackup = playerX;
                            playerY -= int.Parse(Console.ReadLine());

                            if ((playerY < 1 || playerY > 10) || (playerX < 1 || playerX > 10))
                            {
                                playerX = playerXBackup;
                                playerY = playerYBackup;
                                Console.WriteLine("that is not a choice. What would you like to do?");
                                InGoblinCamp();
                            }

                            Console.WriteLine($"you are at X: {playerX} and Y: {playerY}");
                            Console.WriteLine();
                            Console.WriteLine("the goblin took it's change to attack while you where moving");
                            playerHealth -= EatDamage();
                            Console.WriteLine($"you have {playerHealth} Health left");
                            CheckLocation();
                        }
                        break;
                    case 3:
                        if (!goblinAlive)
                        { 
                        Console.WriteLine("how many would you like to go east?");
                        playerYBackup = playerY;
                        playerXBackup = playerX;
                        playerX += int.Parse(Console.ReadLine());

                        if ((playerY < 1 || playerY > 10) || (playerX < 1 || playerX > 10))
                        {
                            playerX = playerXBackup;
                            playerY = playerYBackup;
                            Console.WriteLine("that is not a choice. What would you like to do?");
                            InGoblinCamp();
                        }

                        Console.WriteLine($"you are at X: {playerX} and Y: {playerY}");
                        CheckLocation();
                        }
                        else
                        {
                            //Console.WriteLine("you are in a fight, FIGHT. what would you like to do?");
                            //InGoblinCamp();
                            Console.WriteLine("how many would you like to go east?");
                            playerYBackup = playerY;
                            playerXBackup = playerX;
                            playerX += int.Parse(Console.ReadLine());

                            if ((playerY < 1 || playerY > 10) || (playerX < 1 || playerX > 10))
                            {
                                playerX = playerXBackup;
                                playerY = playerYBackup;
                                Console.WriteLine("that is not a choice. What would you like to do?");
                                InGoblinCamp();
                            }

                            Console.WriteLine($"you are at X: {playerX} and Y: {playerY}");
                            Console.WriteLine();
                            Console.WriteLine("the goblin took it's change to attack while you where moving");
                            playerHealth -= EatDamage();
                            Console.WriteLine($"you have {playerHealth} Health left");
                            CheckLocation();
                        }
                        break;
                    case 4:
                        if (!goblinAlive) { 
                        Console.WriteLine("how many would you like to go south?");
                        playerYBackup = playerY;
                        playerXBackup = playerX;
                        playerY += int.Parse(Console.ReadLine());

                        if ((playerY < 1 || playerY > 10) || (playerX < 1 || playerX > 10))
                        {
                            playerX = playerXBackup;
                            playerY = playerYBackup;
                            Console.WriteLine("that is not a choice. What would you like to do?");
                            InGoblinCamp();
                        }

                        Console.WriteLine($"you are at X: {playerX} and Y: {playerY}");
                        CheckLocation();
                        }
                        else
                        {
                            //Console.WriteLine("you are in a fight, FIGHT. what would you like to do?");
                            //InGoblinCamp();
                            Console.WriteLine("how many would you like to go south?");
                            playerYBackup = playerY;
                            playerXBackup = playerX;
                            playerY += int.Parse(Console.ReadLine());

                            if ((playerY < 1 || playerY > 10) || (playerX < 1 || playerX > 10))
                            {
                                playerX = playerXBackup;
                                playerY = playerYBackup;
                                Console.WriteLine("that is not a choice. What would you like to do?");
                                InGoblinCamp();
                            }

                            Console.WriteLine($"you are at X: {playerX} and Y: {playerY}");
                            Console.WriteLine();
                            Console.WriteLine("the goblin took it's change to attack while you where moving");
                            playerHealth -= EatDamage();
                            Console.WriteLine($"you have {playerHealth} Health left");
                            CheckLocation();
                        }
                        break;
                    case 5:
                        if (!goblinAlive) 
                        { 
                        Console.WriteLine("how many would you like to go west?");
                        playerYBackup = playerY;
                        playerXBackup = playerX;
                        playerX -= int.Parse(Console.ReadLine());

                        if ((playerY < 1 || playerY > 10) || (playerX < 1 || playerX > 10))
                        {
                            playerX = playerXBackup;
                            playerY = playerYBackup;
                            Console.WriteLine("that is not a choice. What would you like to do?");
                            InGoblinCamp();
                        }

                        Console.WriteLine($"you are at X: {playerX} and Y: {playerY}");
                        CheckLocation();
                        }
                        else
                        {
                            //Console.WriteLine("you are in a fight, FIGHT. what would you like to do?");
                            //InGoblinCamp();
                            Console.WriteLine("how many would you like to go west?");
                            playerYBackup = playerY;
                            playerXBackup = playerX;
                            playerX -= int.Parse(Console.ReadLine());

                            if ((playerY < 1 || playerY > 10) || (playerX < 1 || playerX > 10))
                            {
                                playerX = playerXBackup;
                                playerY = playerYBackup;
                                Console.WriteLine("that is not a choice. What would you like to do?");
                                InGoblinCamp();
                            }

                            Console.WriteLine($"you are at X: {playerX} and Y: {playerY}");
                            Console.WriteLine();
                            Console.WriteLine("the goblin took it's change to attack while you where moving");
                            playerHealth -= EatDamage();
                            Console.WriteLine($"you have {playerHealth} Health left");
                            CheckLocation();

                        }
                        break;
                    case 6:
                        if (goblinAlive)
                        {
                            Console.WriteLine("you attack the goblin");
                            goblinHealth -= DealDamage();
                            Console.WriteLine($"the goblin has {goblinHealth} Health left!");
                            Console.WriteLine();
                            CheckHealthPools();

                            Console.WriteLine("but oh no the goblin attacks back!");
                            playerHealth -= EatDamage();
                            Console.WriteLine($"you have {playerHealth} Health left");
                            CheckHealthPools();

                            Console.WriteLine("what would you like to do now?");
                            InGoblinCamp();
                        }
                        else
                        {
                            Console.WriteLine("that is not a choice. What would you like to do?");
                            InGoblinCamp();
                        }
                        break;
                    case 7:
                        if (goblinAlive)
                        {
                            Console.WriteLine("you defend the goblins attack!");
                        }
                        else
                        {
                            Console.WriteLine("that is not a choice. What would you like to do?");
                            InGoblinCamp();
                        }
                        break;
                    default:
                        Console.WriteLine("that is not a choice. What would you like to do?");
                        InGoblinCamp();
                        break;
                }
            }

            void InWeirdShop()
            {
                Console.WriteLine("1. look at map");
                Console.WriteLine("2. go North");
                Console.WriteLine("3. go East");
                Console.WriteLine("4. go South");
                Console.WriteLine("5. go West");
                if (!inventory.Contains("wizardSword"))
                {
                    Console.WriteLine("6. i need a second sword");
                }
                if (playerHealth < 9)
                {
                    Console.WriteLine("7. i need my health back");
                }

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //GenerateForestMap();
                        ShowForestMap();
                        Console.WriteLine("what would you like to do?");
                        InWeirdShop();
                        break;
                    case 2:
                        Console.WriteLine("how many would you like to go north?");
                        playerYBackup = playerY;
                        playerXBackup = playerX;
                        playerY -= int.Parse(Console.ReadLine());

                        if ((playerY < 1 || playerY > 10) || (playerX < 1 || playerX > 10))
                        {
                            playerX = playerXBackup;
                            playerY = playerYBackup;
                            Console.WriteLine("that is not a choice. What would you like to do?");
                            InWeirdShop();
                        }

                        Console.WriteLine($"you are at X: {playerX} and Y: {playerY}");
                        CheckLocation();
                        break;
                    case 3:
                        Console.WriteLine("how many would you like to go east?");
                        playerYBackup = playerY;
                        playerXBackup = playerX;
                        playerX += int.Parse(Console.ReadLine());

                        if ((playerY < 1 || playerY > 10) || (playerX < 1 || playerX > 10))
                        {
                            playerX = playerXBackup;
                            playerY = playerYBackup;
                            Console.WriteLine("that is not a choice. What would you like to do?");
                            InWeirdShop();
                        }

                        Console.WriteLine($"you are at X: {playerX} and Y: {playerY}");
                        CheckLocation();
                        break;
                    case 4:
                        Console.WriteLine("how many would you like to go south?");
                        playerYBackup = playerY;
                        playerXBackup = playerX;
                        playerY += int.Parse(Console.ReadLine());

                        if ((playerY < 1 || playerY > 10) || (playerX < 1 || playerX > 10))
                        {
                            playerX = playerXBackup;
                            playerY = playerYBackup;
                            Console.WriteLine("that is not a choice. What would you like to do?");
                            InWeirdShop();
                        }

                        Console.WriteLine($"you are at X: {playerX} and Y: {playerY}");
                        CheckLocation();
                        break;
                    case 5:
                        Console.WriteLine("how many would you like to go west?");
                        playerYBackup = playerY;
                        playerXBackup = playerX;
                        playerX -= int.Parse(Console.ReadLine());

                        if ((playerY < 1 || playerY > 10) || (playerX < 1 || playerX > 10))
                        {
                            playerX = playerXBackup;
                            playerY = playerYBackup;
                            Console.WriteLine("that is not a choice. What would you like to do?");
                            InWeirdShop();
                        }

                        Console.WriteLine($"you are at X: {playerX} and Y: {playerY}");
                        CheckLocation();
                        break;
                    case 6:
                        if (!inventory.Contains("wizardSword"))
                        {
                            Console.WriteLine();

                            Console.WriteLine("ah yes a second weapon i shall grant you this");
                            Console.WriteLine("but it will cost you your normal sword and shield");
                            inventory.Add("wizardSword");
                            inventory.Remove("sword");
                            inventory.Remove("shield");

                            Console.WriteLine("What would you like to do?");
                            InWeirdShop();
                        }
                        else
                        {
                            Console.WriteLine();

                            Console.WriteLine("that is not a choice. What would you like to do?");
                            InWeirdShop();
                        }
                        break;
                    case 7:
                        if (playerHealth < 9)
                        {
                            Console.WriteLine();

                            Console.WriteLine("you are hurt");
                            Console.WriteLine("take this safe potion to help");
                            playerHealth = 9;

                            Console.WriteLine("What would you like to do?");
                            InWeirdShop();
                        }
                        else
                        {
                            Console.WriteLine();

                            Console.WriteLine("that is not a choice. What would you like to do?");
                            InWeirdShop();
                        }
                        break;
                    default:
                        Console.WriteLine("that is not a choice. What would you like to do?");
                        InWeirdShop();
                        break;
                }
            }

            void InRuins()
            {
                Console.WriteLine("1. look at map");
                Console.WriteLine("2. go North");
                Console.WriteLine("3. go East");
                Console.WriteLine("4. go South");
                Console.WriteLine("5. go West");
                Console.WriteLine("6. look around");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //GenerateForestMap();
                        ShowForestMap();
                        Console.WriteLine("what would you like to do?");
                        InRuins();
                        break;
                    case 2:
                        Console.WriteLine("how many would you like to go north?");
                        playerYBackup = playerY;
                        playerXBackup = playerX;
                        playerY -= int.Parse(Console.ReadLine());

                        if ((playerY < 1 || playerY > 10) || (playerX < 1 || playerX > 10))
                        {
                            playerX = playerXBackup;
                            playerY = playerYBackup;
                            Console.WriteLine("that is not a choice. What would you like to do?");
                            InRuins();
                        }

                        Console.WriteLine($"you are at X: {playerX} and Y: {playerY}");
                        CheckLocation();
                        break;
                    case 3:
                        Console.WriteLine("how many would you like to go east?");
                        playerYBackup = playerY;
                        playerXBackup = playerX;
                        playerX += int.Parse(Console.ReadLine());

                        if ((playerY < 1 || playerY > 10) || (playerX < 1 || playerX > 10))
                        {
                            playerX = playerXBackup;
                            playerY = playerYBackup;
                            Console.WriteLine("that is not a choice. What would you like to do?");
                            InRuins();
                        }

                        Console.WriteLine($"you are at X: {playerX} and Y: {playerY}");
                        CheckLocation();
                        break;
                    case 4:
                        Console.WriteLine("how many would you like to go south?");
                        playerYBackup = playerY;
                        playerXBackup = playerX;
                        playerY += int.Parse(Console.ReadLine());

                        if ((playerY < 1 || playerY > 10) || (playerX < 1 || playerX > 10))
                        {
                            playerX = playerXBackup;
                            playerY = playerYBackup;
                            Console.WriteLine("that is not a choice. What would you like to do?");
                            InRuins();
                        }

                        Console.WriteLine($"you are at X: {playerX} and Y: {playerY}");
                        CheckLocation();
                        break;
                    case 5:
                        Console.WriteLine("how many would you like to go west?");
                        playerYBackup = playerY;
                        playerXBackup = playerX;
                        playerX -= int.Parse(Console.ReadLine());

                        if ((playerY < 1 || playerY > 10) || (playerX < 1 || playerX > 10))
                        {
                            playerX = playerXBackup;
                            playerY = playerYBackup;
                            Console.WriteLine("that is not a choice. What would you like to do?");
                            InRuins();
                        }

                        Console.WriteLine($"you are at X: {playerX} and Y: {playerY}");
                        CheckLocation();
                        break;
                    case 6:
                        if (!magicSwordPickedUp)
                        {
                            Console.WriteLine();

                            Console.WriteLine("you look around and find a sword in a rock");
                            Console.WriteLine("you pull it out and BOOM, it's a magic sword");
                            inventory.Add("magicSword");
                            //inventory.Remove("sword");
                            magicSwordPickedUp = true;

                            Console.WriteLine("What would you like to do?");
                            InRuins();
                        } else
                        {
                            Console.WriteLine();

                            Console.WriteLine("you found nothing new. What would you like to do?");
                            InRuins();
                        }
                        break;
                    default:
                        Console.WriteLine("that is not a choice. What would you like to do?");
                        InRuins();
                        break;
                }
            }

            //excess methods
            void CheckLocation()
            {
                if (playerX == 1 && playerY == 4)
                {
                    forest = Forest.goblinCamp;
                }
                else if (playerX == 5 && playerY == 2)
                {
                    forest = Forest.ruins;
                }
                else if (playerX == 6 && playerY == 7)
                {
                    forest = Forest.weirdShop;
                }
                else
                {
                    forest = Forest.forest;
                }

                if (forest == Forest.forest)
                {
                    Console.WriteLine();
                    Console.WriteLine("you are standing in the forest. What would you like to do?");

                    InForest();
                }
                if (forest == Forest.goblinCamp)
                {
                    if (goblinAlive)
                    {
                        Console.WriteLine();

                        Console.WriteLine("you entered the goblin camp, there is one goblin.");
                        Console.WriteLine("he doesn't like you. FIGHT.");
                        Console.WriteLine();
                        Console.WriteLine("what would you like to do?");
                    }
                    if (!goblinAlive)
                    {
                        Console.WriteLine();

                        Console.WriteLine("there are no goblins.");
                        Console.WriteLine("what would you like to do?");
                    }
                    InGoblinCamp();
                }
                if (forest == Forest.weirdShop)
                {
                    Console.WriteLine();

                    Console.WriteLine("you've entered a weird shop");
                    Console.WriteLine("a goofy man speaks to you");
                    Console.WriteLine("hello what would you like to buy?");
                    InWeirdShop();
                }
                if (forest == Forest.ruins)
                {
                    Console.WriteLine();

                    Console.WriteLine("you come across some ruins");
                    Console.WriteLine("what would you like to do?");
                    InRuins();
                }
            }

            void GenerateForestMap()
            {
                for (int i = 0; i < grid.GetLength(0); i++)
                {
                    for (int j = 0; j < grid.GetLength(1); j++)
                    {
                        int rnd = random.Next(0, characters.Length);
                        grid[j, i] = characters[rnd];
                    }
                }
                grid[1, 4] = '1';
                grid[5, 2] = '2';
                grid[6, 7] = '3';
                //grid[playerX, playerY] = 'X';
            }

            void ShowForestMap()
            {
                for (int i = 0; i < grid.GetLength(0); i++)
                {
                    for (int j = 0; j < grid.GetLength(1); j++)
                    {
                        if (j == playerX && i == playerY) 
                        {
                            Console.Write("X" + " ");
                        } else
                        {
                            Console.Write(grid[j, i] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("1 = goblin camp");
                Console.WriteLine("2 = ruins");
                Console.WriteLine("3 = weird shop");
                Console.WriteLine($"you are at X: {playerX + 1} and Y: {playerY + 1}");
                Console.WriteLine();
            }

            //combat
            int DealDamage()
            {
                int DeltDamage = playerAttack;
                if (inventory.Contains("magicSword"))
                {
                    DeltDamage += 3;
                }
                else if (inventory.Contains("sword"))
                {
                    DeltDamage += 1;
                }
                if (inventory.Contains("wizardSword"))
                {
                    DeltDamage += 2;
                }
                return DeltDamage;
            }

            int EatDamage()
            {
                int TakeDamage = goblinAttack;
                if (inventory.Contains("shield"))
                {
                    TakeDamage -= 1;
                }
                if (inventory.Contains("chestPlate"))
                {
                    TakeDamage -= 1;
                }
                return TakeDamage;
            }

            void CheckHealthPools()
            {
                if (playerHealth < 1)
                {
                    Console.WriteLine("you died :(");
                    Environment.Exit(0);
                }
                if (goblinHealth < 1)
                {
                    goblinAlive = false;
                    Console.WriteLine("you killed the goblin :)");
                    Console.WriteLine("you won!");
                    Environment.Exit(0);
                }
            }
        }
    }
}