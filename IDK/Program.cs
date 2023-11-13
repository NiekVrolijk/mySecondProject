namespace IDK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 8;
            //int num2 = 2;

            //Console.WriteLine(num1);
            //AddAndMultiply();
            //Console.WriteLine(num2);
            //AddAndMultiply();
            //Console.WriteLine(num2);
            //AddAndMultiply();
            //Console.WriteLine(num2);

            //void AddAndMultiply()
            //{
            //    num2 = num1 + num2;
            //    num2 = num2 * 2;
            //}




            //random
            //int roll1;
            //Random random = new Random();


            //RollDie();
            //RollDie();
            //RollDie();
            //RollDie();
            //RollDie();

            //void RollDie()
            //{
            //    roll1 = random.Next(1, 21);
            //    Console.WriteLine($"hi you rolled {roll1}");
            //}


            int player1;
            int player2;
            Random random1 = new Random();
            Random random2 = new Random();

            DiceRoll();

            void DiceRoll()
            {
                player1 = random1.Next(1, 7);
                player2 = random2.Next(1, 7);

                Console.WriteLine($"player1 rolled {player1}");
                Console.WriteLine($"player2 rolled {player2}");
                if (player1 < player2)
                {
                    Console.WriteLine("player2 wins");
                } else if (player1 > player2)
                {
                    Console.WriteLine("player1 wins");
                } else if(player1 == player2)
                {
                    Console.WriteLine("tie");
                }
            }
        }
    }
}