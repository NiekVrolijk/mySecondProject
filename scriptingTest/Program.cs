internal class Program
{
    private static void Main(string[] args)
    {
        #region question 1/4
        /* Q1: a variable is a piece of code that is remembered by the program and can be assined different values depending
        on the type of veriable*/
        /* Q2:  the type of variable (like bool), the name of the variable (like redLight), 
           and the value (like true (incase of a bool))*/
        /* Q3:  bool (either true or false), float (a number with a "." like 10.9; outside of code ","), 
           string (stores text like "Hello World")*/
        /* Q4:  a condition are certain cryteria. like if (bool redLight == true) {"stop"} the cryteria/condition is 
         redLight == true*/
        #endregion

        #region question 5
        /*Q5*/
        //var
        int count = 5;

        //write count into console. then add one and write again, repeat 3 times
        Console.WriteLine(count);
        AddOne();
        Console.WriteLine(count);
        AddOne();
        Console.WriteLine(count);
        AddOne();
        Console.WriteLine(count);
        Console.WriteLine();
        //add method called addOne that adds one to int count
        void AddOne()
        {
            count += 1;
        }
        #endregion

        #region question 6
        /*Q6*/
        //var
        int secondCount = 0;
        int numToAdd = 3;

        //write secondCount into console. then activate AddMore and write again, repeat 3 times
        Console.WriteLine(secondCount);
        AddMore();
        Console.WriteLine(secondCount);
        AddMore();
        Console.WriteLine(secondCount);
        AddMore();
        Console.WriteLine(secondCount);
        Console.WriteLine();
        //method that adds numToAdd to secondCount. Then adds 3 too numToAdd
        void AddMore()
        {
            secondCount += numToAdd;
            numToAdd += 3;
        }
        #endregion

        #region question 7/8
        /*Q7*/
        SelectionMenu();
        /*Q8*/
        void SelectionMenu()
        {
            //var
            string choice;

            //first inform the viewer then read whatever the viewer types and assine that to string choice
            Console.WriteLine("Welkom to Delgadio's Dubious Delicacies");
            Console.WriteLine("please select option by typing 1, 2, 3 or 4, and then pressing enter");
            Console.WriteLine("what would you like today: ");
            Console.WriteLine("1: Durian Dolmas");
            Console.WriteLine("2: Duck Flavoured Daquiris");
            Console.WriteLine("3: Dung Beetle Delight");
            Console.WriteLine("4: Dirt-Dusted Donuts");
            choice = Console.ReadLine();

            // respond according to what the viewer has typed into the console
            if (choice == "1")
            {
                Console.WriteLine();
                Console.WriteLine("you have selected dish Durian Dolmas. Thank you for your order. ");
            }
            else if (choice == "2")
            {
                Console.WriteLine();
                Console.WriteLine("you have selected dish Duck Flavoured Daquiris. Thank you for your order. ");
            }
            else if (choice == "3")
            {
                Console.WriteLine();
                Console.WriteLine("you have selected dish Dung Beetle Delight. Thank you for your order. ");
            }
            else if (choice == "4")
            {
                Console.WriteLine();
                Console.WriteLine("you have selected dish Dirt-Dusted Donuts. Thank you for your order. ");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("That is not on the menu. Please try again.");
                Console.WriteLine();
                SelectionMenu();
            }
            Console.WriteLine();

        }
        #endregion
    }
}