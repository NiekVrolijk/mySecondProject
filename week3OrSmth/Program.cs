namespace week3OrSmth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //var
            int a = 0; //camelCase
            int b = 0;
            int c = 0;
            string choice;

            //stuff 

            Console.WriteLine("what would you like to do?");
            Console.WriteLine("A: add");
            Console.WriteLine("B: subtract");
            Console.WriteLine("C: multiply");
            Console.WriteLine("D: divide");
            Console.WriteLine();

            choice = Console.ReadLine();
            if (choice == "A" || choice == "a")
            {
                Calculator();
                AddNumbers();
            }
            else if (choice == "B" || choice == "b")
            {
                Calculator();
                SubtractNumbers();
            }
            else if (choice == "C" || choice == "c")
            {
                Calculator();
                MultiplyNumbers();
            }
            else if (choice == "D" || choice == "d")
            {
                Calculator();
                DivideNumbers();
            }

            //methods
            void Calculator() //PascalCase
            {
                //this is our method
                Console.WriteLine("calculator");
                Console.Write("number 1: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("number 2: ");
                b = int.Parse(Console.ReadLine());
            }

            void AddNumbers()
            {
                c = a + b;
                Console.WriteLine();
                Console.WriteLine($"answer = {c}");
            }
            void SubtractNumbers()
            {
                c = a - b;
                Console.WriteLine();
                Console.WriteLine($"answer = {c}");
            }
            void MultiplyNumbers()
            {
                c = a * b;
                Console.WriteLine();
                Console.WriteLine($"answer = {c}");
            }
            void DivideNumbers()
            {
                c = a / b;
                Console.WriteLine();
                Console.WriteLine($"answer = {c}");
            }
        }
    }
}