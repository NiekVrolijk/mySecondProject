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
            menu();
            choices();

            void menu()
            {
                Console.WriteLine("what would you like to do?");
                Console.WriteLine("A: add");
                Console.WriteLine("B: subtract");
                Console.WriteLine("C: multiply");
                Console.WriteLine("D: divide");
                Console.WriteLine();
            }

            void choices()
            {
                choice = Console.ReadLine();
                if (choice == "A" || choice == "a" || choice == "add")
                {
                    Calculator();
                    AddNumbers();
                }
                else if (choice == "B" || choice == "b" || choice == "subtract")
                {
                    Calculator();
                    SubtractNumbers();
                }
                else if (choice == "C" || choice == "c" || choice == "multiply")
                {
                    Calculator();
                    MultiplyNumbers();
                }
                else if (choice == "D" || choice == "d" || choice == "divide")
                {
                    Calculator();
                    DivideNumbers();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("that is not one of the given options");
                }
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