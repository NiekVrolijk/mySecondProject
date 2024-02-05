
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace _8ballz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string anotherQuestion = "lol no";
            List<string> respondes8Ball = new List<string>() {
            "It is certain",
            "It is decidedly so",
            "Without a doubt",
            "Yes definitely",
            "You may rely on it",
            "As I see it, yes",
            "Most likely",
            "Outlook good",
            "Yes",
            "Signs point to yes",
            "Reply hazy, try again",
            "Ask again later",
            "Better not tell you now",
            "Cannot predict now",
            "Concentrate and ask again",
            "Don’t count on it",
            "My reply is no",
            "My sources say no",
            "Outlook not so good",
            "Very doubtful" };

            Console.WriteLine("what yes or no question would you like to have answered today: ");

            Responds();

            void Responds()
            {
                Console.ReadLine();
                Random rndResponds = new Random();
                int responds = rndResponds.Next(0, 20);
                Console.WriteLine();
                Console.WriteLine(respondes8Ball[responds]);
                Console.WriteLine();


                Console.WriteLine("would you like to ask another question?");
                anotherQuestion = Console.ReadLine();
                if (anotherQuestion == "yes" || anotherQuestion == "YES")
                {
                    Console.WriteLine();
                    Console.WriteLine("ok you may now ask another question: ");
                    Responds();
                } else
                {
                    Console.WriteLine("very well");
                }
            }



        }
    }
}