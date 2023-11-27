using System.ComponentModel.Design;

namespace _27_11_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string passwordGuess;
            //string passwordAnswer = "hello_world";
            //bool fillInBoolean = false;
            //int guessCount = 379027;

            //Console.Write("Please enter your password: ");
            //passwordGuess = Console.ReadLine();
            //do
            //{
            //    Guessing();
            //} while (fillInBoolean == false);



            //void Guessing()
            //{
            //    if (passwordGuess == passwordAnswer)
            //    {
            //        Console.WriteLine("Hello Niek");
            //        fillInBoolean = true;
            //    }
            //    else if (guessCount <= 379029)
            //    {
            //        Console.Write("please try again: ");
            //        passwordGuess = Console.ReadLine();
            //        fillInBoolean = false;
            //        guessCount++;
            //        Guessing();
            //    } else if (guessCount > 379029) 
            //    {
            //        Console.WriteLine("sorry you've guessed enough");
            //        fillInBoolean = true;
            //    }
            //}



            //bool breakloop = false;
            //string userInput;

            //Console.WriteLine("hello welkom to my restorant we have 3 things to buy: 1st, frog soup/ 2nd, liver pudding/ 3rd, mean creamed ice");
            //Console.Write("what would you like?: ");
            //userInput = Console.ReadLine();

            //while (breakloop == false)
            //{
            //    if (userInput == "1")
            //    {
            //        FrogSoup();
            //    } else if (userInput == "2")
            //    {
            //        LiverPudding();
            //    } else if (userInput == "3")
            //    {
            //        MeanCreamedIce();
            //    } else if (userInput == "exit")
            //    {
            //        Console.WriteLine("oki goodbye");
            //        breakloop = true;
            //    }
            //    else
            //    {
            //        Console.Write("please try again: ");
            //        userInput = Console.ReadLine();
            //        TryAgain();
            //    }
            //}

            //void FrogSoup()
            //{
            //    Console.WriteLine("you chose: frog soup, good choice");
            //    breakloop = true;
            //}

            //void LiverPudding()
            //{
            //    Console.WriteLine("you chose: liver pudding, ok choice");
            //    breakloop = true;
            //}

            //void MeanCreamedIce()
            //{
            //    Console.WriteLine("you chose: mean creamed ice, not my fav, ngl");
            //    breakloop = true;
            //}

            //void TryAgain()
            //{
            //    while (breakloop == false)
            //    {
            //        if (userInput == "1")
            //        {
            //            FrogSoup();
            //        }
            //        else if (userInput == "2")
            //        {
            //            LiverPudding();
            //        }
            //        else if (userInput == "3")
            //        {
            //            MeanCreamedIce();
            //        }
            //        else if (userInput == "exit")
            //        {
            //            Console.WriteLine("oki goodbye");
            //            breakloop = true;
            //        }
            //        else
            //        {
            //            Console.Write("please try again: ");
            //            userInput = Console.ReadLine();
            //            TryAgain();
            //        }
            //    }
            //}

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.Black;

            //int lol= 25;
            //for (int i = 0; i <= lol; i++) 
            //{
            //    if (i < 20 || i > 20)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    else
            //    {
            //        Console.WriteLine("TWENTY!!");
            //    }
            //}


            //int p = 1234;
            //p %= 124;
            //Console.WriteLine(p);


            //for (int i = 0; i <= 50; i++) 
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Magenta;
            //        Console.BackgroundColor = ConsoleColor.Cyan;
            //        Console.WriteLine($"{i}: even number");

            //    }
            //    else if (i % 2 ==1)
            //    {
            //        Console.ForegroundColor = ConsoleColor.DarkBlue;
            //        Console.BackgroundColor = ConsoleColor.Yellow;
            //        Console.WriteLine($"{i}: odd number");

            //    }
            //}


            for (int i = 1; i <= 100; i++) 
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("FIZZBUZZ");
                } else if (i % 3 == 0) 
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("FIZZ");
                } else if (i % 7 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("BUZZ");
                } else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine(i);
                }
            }


        }
    }
}