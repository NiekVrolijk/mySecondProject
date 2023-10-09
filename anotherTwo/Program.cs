namespace anotherTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            int anotherNum = 0;

            AddsFive();
            AddsFive();
            AddsFive();
            AddsFive();
            AddsFive();


            void AddsFive()
            {
                num += 5;
                Console.WriteLine(num);
            }

            void AddsOneMoreEveryTime()
            {
                anotherNum += 1;
                Console.WriteLine(num);
            }

        }
    }
}