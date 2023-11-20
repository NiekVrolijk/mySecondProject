namespace ahhhh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string notANumber = "8";
            //int thisIsANumber = int.Parse(notANumber);

            //string notANumber;
            //int thisIsANumber;
            //bool result = false;

            //Console.WriteLine("hello user. Please type a number: ");
            ////notANumber = Console.ReadLine();
            ////thisIsANumber = int.Parse(notANumber);
            ////Console.WriteLine($"is this your number? {thisIsANumber}");
            //Console.WriteLine(int.TryParse(notANumber, out thisIsANumber));

            //if (int.TryParse(notANumber, out thisIsANumber))
            //{
            //    Console.WriteLine($"is this your number? {thisIsANumber}");
            //}
            //else
            //{
            //    Console.WriteLine("bro you know better");
            //}



            //int playerNum;
            //string playerInput;
            //int winningNum;
            //bool numberIsGuessed = false;

            //Random rNum = new Random();
            //winningNum = rNum.Next(1, 101);
            //guess();

            //void guess()
            //{
            //    Console.Write("guess a number between 1 and 100: ");
            //    playerInput = Console.ReadLine();
            //    int.TryParse(playerInput, out playerNum);

            //    while (!numberIsGuessed)
            //    {
            //        if (playerNum > winningNum)
            //        {
            //            Console.WriteLine("lower");
            //            guess();
            //        }
            //        else if (playerNum < winningNum)
            //        {
            //            Console.WriteLine("higher");
            //            guess();
            //        }
            //        else if (playerNum == winningNum)
            //        {
            //            Console.WriteLine("correct");
            //            numberIsGuessed = true;
            //        }
            //    }


            ////for loop
            //int numOfTimes = 666;

            //for (int i = 0; i < numOfTimes; i++) //i is for iterator
            //{
            //    Console.WriteLine($"aahhhhhhh {i+1}");
            //}


            ////do
            //bool lightIsOn = true;

            ////checks after do
            //do
            //{
            //    Console.WriteLine("do-while says light on");
            //}while (lightIsOn);

            ////checks before do
            //while (lightIsOn)
            //{
            //    Console.WriteLine("do-while says light on");
            //}
            ////same thing pretty much

            int playerNum;
            string playerInput;
            int winningNum;
            bool numberIsGuessed = false;

            Random rNum = new Random();
            winningNum = rNum.Next(1, 101);
            

            while (!numberIsGuessed)
            
            {
                Console.Write("guess a number between 1 and 100: ");
                playerInput = Console.ReadLine();
                int.TryParse(playerInput, out playerNum);

                
                if (playerNum > winningNum)
                {
                    Console.WriteLine("lower");
                }
                else if (playerNum < winningNum)
                {
                    Console.WriteLine("higher");
                }
                else if (playerNum == winningNum)
                {
                    Console.WriteLine("correct");
                    numberIsGuessed = true;
                }
                
            }

        }
    }
}