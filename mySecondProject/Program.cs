using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace mySecondProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region welkoming messages
            //welkom's by saying hello world
            //Console.WriteLine("Hello, World!");






            #endregion

            #region variables
            //so, we are going to make some variables

            //fist one is a string veriable!
            //string userName = "Niek";

            ////second one is character veriable
            //char myFarvoriteOneEver = ';';

            ////interge
            //int age = 17;

            ////float
            //float pi = 3.14159265358979323846264338327950288f;

            ////double
            //double simplepi = 3.1415;

            ////boolean
            //bool lovesCat = true;

            //user imput
            string userImput;
            int userAge;
            int expectedAge = 18;

            //user imput variables
            string userImputName;
            string userImputPassword;

            //v for expected values

            string expectedName = "Niek";
            string expectedPassword = "Password";

            string whenTheMoonHitsYourEyesLikeABigPizzaPie = "no";

            /*
                        Console.WriteLine("something");
                        Console.WriteLine(); //white space
                        Console.WriteLine("something else");
                        Console.WriteLine(userName);
                        Console.WriteLine(myFarvoriteOneEver);
                        Console.WriteLine(age);
                        Console.WriteLine(pi);
                        Console.WriteLine(simplepi);
                        Console.WriteLine(lovesCat);
                        Console.WriteLine();

                        Console.WriteLine("hi my name is " + userName);
                        Console.WriteLine("hi my name is {0}", userName);
                        Console.WriteLine("hi my age is " + age);
                        Console.WriteLine("hi my name is {0} and I am {1} years old", userName, age);
                        Console.WriteLine($"my name is {userName} and i am {age} years old");
            */

            //age checker in progress

            //Console.Write("please enter your name: ");
            //userImput = Console.ReadLine();
            //Console.WriteLine($"hi {userImput}");
            //Console.Write("please also give me your age: ");
            //userAge = Console.Read();
            //if (userAge > expectedAge)
            //{
            //    Console.WriteLine($"hi {userImput}, age {userAge}");
            //}
            //else
            //{
            //    Console.WriteLine($"sorry {userImput} you're not old enough");
            //}


            //password defender
            //    Console.Write("please enter your name: ");
            //    userImputName = Console.ReadLine();

            //    Console.Write("please enter your password: ");
            //    userImputPassword = Console.ReadLine();

            //    if (userImputName == expectedName && userImputPassword == expectedPassword)
            //    {
            //        Console.WriteLine("wow it's you");
            //    }
            //    else
            //    {
            //        Console.WriteLine("how dare you, you fake");
            //    }


            //amore
            Console.Write("Does the moon hit your eyes like a big pizza pie: ");
            whenTheMoonHitsYourEyesLikeABigPizzaPie = Console.ReadLine();
            if (whenTheMoonHitsYourEyesLikeABigPizzaPie == "yes")
            {
                Console.Write("That's amore");

            }
            else
            {
                Console.Write("That's not amore");
            }

            #endregion



            /*
             * 
             * 
             * hi 
             * hi
             */
        }
    }
}