namespace _18_12_2023_catcannon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int player = 0;
            int CNum;
            string playerInput;
            string amountOfBarrlesString;
            int amountOfBarrles;

            Console.WriteLine("hello you have joined the cat roulette game. please choose how many barrles you would like");
            amountOfBarrlesString = Console.ReadLine();
            int.TryParse(amountOfBarrlesString, out amountOfBarrles);

            bool[] cannon = new bool[amountOfBarrles];

            for (int i = 0; i < amountOfBarrles; i++)
            {
                cannon[i] = false;
            }

            Random num = new Random();
            CNum = num.Next(0, amountOfBarrles);

            cannon[CNum] = true;

            Console.WriteLine("Player 1, please give me any input: ");
            PlayerTurn();


            void PlayerTurn()
            {
                playerInput = Console.ReadLine();
                if (playerInput !=  null)
                {
                    ShootCannon();
                } else
                {
                    ShootCannon();
                }
            }

            void ShootCannon()
            {
                player++;
                if (cannon[player -1] == true && player % 2 == 1) 
                {
                    Console.WriteLine("player 1 wins. goodjob :)");
                }
                else if (cannon[player -1] == true && player % 2 == 0)
                {
                    Console.WriteLine("player 2 wins. goodjob :)");
                }
                else if (cannon[player - 1] == false && player % 2 == 1)
                {
                    Console.WriteLine("player 1 didn't win. player 2's turn; " + player + " shot('s) fired");
                    PlayerTurn();
                }
                else if (cannon[player - 1] == false && player % 2 == 0)
                {
                    Console.WriteLine("player 2 didn't win. player 1's turn; " + player + " shot('s) fired");
                    PlayerTurn();
                }

            }
        }
    }
}