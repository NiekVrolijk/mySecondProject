namespace switchCase
{
    internal class Program
    {
        enum room { apple, banana, fruit }
        static void Main(string[] args)
        {
            //int choice = int.Parse(Console.ReadLine());

            //switch (choice)
            //{
            //    case 1:
            //        Console.WriteLine("something");
            //        break;
            //    case 2:
            //        Console.WriteLine("ahhhh");
            //        break;
            //    default:
            //        Console.WriteLine("rdgfb");
            //        break;
            //}

            //if (choice == 1) Console.WriteLine("choice 1");

            room room;
            room = room.apple;

            switch (room)
            {
                case room.apple:
                    Console.WriteLine("something");
                    break;
                case room.fruit:
                    Console.WriteLine("ahhhh");
                    break;
                case room.banana:
                    Console.WriteLine("ahhhh");
                    break;
                default:
                    Console.WriteLine("rdgfb");
                    break;
            }
        }
    }
}