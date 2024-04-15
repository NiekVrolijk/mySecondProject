namespace classesRock_5_4_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            rock JustARock = new rock();

            Console.WriteLine("the rock is called: " + JustARock.Name);
            Console.WriteLine("the rock tastes: " + JustARock.Taste);
        }
    }
}