using System;

namespace method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region int return
            ////var
            //int a = 0; int b = 0;

            ////code
            //Console.WriteLine("num1 pls");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("num2 pls");
            //b = int.Parse(Console.ReadLine());

            //Console.WriteLine("result");
            //Console.WriteLine(Multiply(a, b));

            ////method
            //int Multiply(int a, int b)
            //{
            //    return a * b;
            //}
            #endregion

            #region string return
            ////var

            ////code
            //for (int i = 0; i < 2000; i++)
            //{
            //    Console.WriteLine("hi, what is your name?");
            //    string name = Console.ReadLine();

            //    Console.WriteLine(Greater(name));
            //}

            ////method
            //string Greater(string n)
            //{
            //    return ($"Hello {n}.");
            //}
            #endregion

            #region Dice roller
            ////var
            //int lowNum;
            //int highNum;
            //int random;

            ////code
            //Console.WriteLine("we will roll a die for you. please enter the lowest and then highest possible numbers.");

            //Dice();

            //void Dice()
            //{
            //    Console.Write("what is the lowest number: ");
            //    lowNum = int.Parse(Console.ReadLine());

            //    Console.Write("what is the highest number: ");
            //    highNum = int.Parse(Console.ReadLine());

            //    Console.WriteLine($"result: {DiceRoller(lowNum, highNum)}");

            //    //method
            //    int DiceRoller(int low, int high)
            //    {
            //        Random rnd = new Random();
            //        random = rnd.Next(low, (high + 1));

            //        return random;
            //    }
            //    Console.WriteLine("would you like to roll another?");
            //    Console.ReadLine();
            //    Dice();
            //}

            #endregion

            #region method assignments
            //var
            int testV1 = 4;

            //code
            if (CalculateHypotenuseBiggerThan5(3, 4))
            {
                Console.WriteLine("yes");
            } else
            {
                Console.WriteLine("no");
            }


            //method
            int Double(int intakeValue)
            {
                return intakeValue * 2;
            }

            int CalculateContent(int length, int width, int height)
            {
                return length * width * height;
            }

            double CalculateSphere(double radius)
            {
                return 3f/4f * Math.PI * Math.Pow(radius, 3);
            }

            double CalculateHypotenuse(double tHeight, double tBase)
            {

                return Math.Sqrt(Math.Pow(tHeight, 2) + Math.Pow(tBase, 2));
            }

            bool CalculateHypotenuseBiggerThan5(double tHeight, double tBase)
            {

                double length = Math.Sqrt(Math.Pow(tHeight, 2) + Math.Pow(tBase, 2));
                if (length > 5)
                {
                    return true;
                }
                else if (length <= 5)
                {
                    return false;
                }
                else
                {
                    return false;
                }
            }
            #endregion
        }
    }
}