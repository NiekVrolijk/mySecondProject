namespace Cheat_Sheet2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Welcome to the Scripting cheat sheet
             * Here you will find everything we learned in class
             * You are allowed to use this sheet during your test */

            #region A. Scripting 1 and 2 cheat sheet

            #region 1. VARIABLES

            /*** VARIABLES ***/
            // - declaration
            // - initialization
            // - naming conventions

            // VARIABLES: declaration
            bool lightIsOn;             // boolean: can have the values true or false
            int num;                    // integer: it's value can only be whole number
            float dec;                  // floating point: a variable for fractional numbers
            char c;                     // character: for the storing of single characters
            string str;                 // string: for storing text


            // VARIABLES: instantiation
            lightIsOn = true;           // can also be false
            num = 1;                    // standard integer range is between -2,147,483,648 and 2,147,483,647
            dec = 99.99f;               // mind the 'f' behind the number if the number contains a fraction
            c = 'x';                    // single quotes for characters
            str = "Hi I am a string";   // double quotes for strings

            string coolStringVariable = "I am so cool"; // you can alse declare and instantiate at the same time


            // VARIABLES: naming conventions
            /* In C# variable names are written in camelCase
             * So, first word NOT capitalized, following words (if any) ARE capitalized
             * Name variables for what they represent, don't use unclear names */

            #endregion



            #region 2. BASIC OPERATIONS

            /*** BASIC OPERATIONS ***/
            // - writing to the console
            // - reading user input
            // - string formatting
            // - basic math


            // BASIC OPERATIONS: writing to the screen with Console.WriteLine()

            /* The Console.WriteLine() method provides output to the console
             *      - The cursor automatically jumps to a new line after the command has been executed
             *      - You can fill it with a value
             *      - You can fill it with a variable (then it will write the VALUE of the variable, not its name)
             *      - You can leave it blank to have it generate a line of whitespace for readability */

            Console.WriteLine("People of the land, hear ye!");  // writing a value: text (string)
            Console.WriteLine(123456);                          // writing a value: number (integer)
            Console.WriteLine(coolStringVariable);              // writing the value of a variable
            Console.WriteLine();                                // leaving it empty to generate an empty line (whitespace)

            /* The Console.Write() method ALSO provides output to the console
             *      - But the cursor does NOT automatically jump to a new line after the command is executed
             *      - This has its uses sometimes, mostly it can be more clear for the user */

            Console.Write("Please enter your name: ");          // take a look at where the cursor is in the console
            Console.WriteLine("Please enter your name: ");      // and notice the difference between this and the WriteLine() method


            // BASIC OPERATIONS: reading user input with Console.ReadLine()

            /* This command stores what the user types after they press the enter key 
             * Take a look at the following example */

            Console.Write("Please enter your name: ");          // Write appropriate instructions for the user
            string userInput = Console.ReadLine();              // This is stored as text, so you use this with string variables
            Console.WriteLine();                                // Some whitespace for readability
            Console.Write("Your name is: " + userInput);        // Write appropriate feedback for the user


            // BASIC OPERATIONS: string formatting

            /* There are quite a few ways to use strings and variables together
             * Here are 3 ways to do it  */

            string name = "Mark";       // some variables to use
            int birthYear = 1982;       // a string and an integer in this case

            Console.WriteLine("Oh hi " + name);                         // using plusses to add things together (mind the spaces!)
            Console.WriteLine("Name: {0}, year: {1}", name, birthYear); // using placeholders, first one is 0, second one is 1 and so on
            Console.WriteLine($"{name} was born in {birthYear}");       // using variable names, mind the dollar sign at the beginning!


            // BASIC OPERATIONS: basic math
            float x = 10; // for whole numbers you don't need to put an f after the number
            float y = 3;
            float answer;

            answer = x + y; // Adding           Answer = 10 + 5 = 15
            answer = x - y; // Subtracting      Answer = 10 - 5 = 5
            answer = x * y; // Multiplication   Answer = 10 * 5 = 50
            answer = x / y; // Dividing         Answer = 10 / 5 = 2

            #endregion



            #region 3. IF STATEMENTS

            /*** IF STATEMENTS ***/
            // - if
            // - else
            // - else if


            // IF STATEMENTS: if

            if (true) // if the condition is 'true'
            {
                // the code you write here will execute
                // if the condition is not true (false) the code will not execute
            }

            /* If statements are used to run a block of code only if a specific condition is met
             * It checks if the condition is true or false, if it is true, the code will run
             * You can, for example, use it to execute it's code when:
             *      - two string variables match
             *      - an integer or other numeric variable has a specific value
             *      - a boolean is true */

            // comparing strings
            string passWordEntered = "welcome1";
            string passWordStored = "welcome1";

            if (passWordEntered == passWordStored)
            {
                Console.WriteLine("Password is correct");
            }

            // comparing integers
            int score = 1;
            int targetScore = 5000;

            if (score == targetScore)
            {
                Console.WriteLine("This code won't run since exampleNum is 1 and not 5000");
            }

            // using a boolean
            bool win = true;

            if (win)
            {
                Console.WriteLine("Yay");
            }

            /* Later this year we'll also do things like
             *      - checking if a number is 
             *          - above a certain value
             *          - below a certain value
             *          - between a certain range
             *      - using multiple conditions in an if statement
             *      - checking if a collection contains a certain value */


            // IF STATEMENTS: else

            /* You can use 'else' to specify what should happen if the condition of the if statement is false */

            if (true) // if the condition is 'true' 
            {
                // the code you write here will execute
            }
            else // if the condition is 'false'
            {
                // the code you write here will execute
            }

            // an example:
            if (passWordEntered == passWordStored)
            {
                Console.WriteLine("Password is correct");
            }
            else
            {
                Console.WriteLine("Password is incorrect");
            }


            // IF STATEMENTS: else if

            /* You use else if when you want to evaluate multiple conditions
             *      - You can use as many as you need 
             *      - You can end with an else if you need to */

            if (true) // if this specific condition is 'true' 
            {
                // the code you write here will execute
            }
            else if (true) // if the first condition is not true, but this one is
            {
                // the code you write here will execute
            }

            // an example:

            string choice = "";

            if (choice == "option 1")
            {
                Console.WriteLine("You have selected option 1.");
            }
            else if (choice == "option 2")
            {
                Console.WriteLine("You have selected option 2.");
            }
            else if (choice == "option 3")
            {
                Console.WriteLine("You have selected option 3.");
            }
            else
            {
                Console.WriteLine("Input invalid or no option selected");
            }

            #endregion



            #region 4. METHODS

            /*** METHODS ***/
            // - Declaring a method
            // - Calling a method

            /* In its simplest form a METHOD is just a container for code
             * You can write code inside the METHOD
             * By calling the METHOD, you run the code inside the code block
             * You can call the METHOD as many times as you like
             * This is really handy if you want to repeat code
             * Methods are written in PascalCase */


            // METHODS: declaring a method

            /* A method is made up of multiple elements:
             *      - Return Type: what type of value the method will return
             *              - for now, we will not return anything
             *              - so our return types will always be VOID (void means empty)
             *      - Method Name: This is the actual name used to refer to the method
             *      - Method Body: This is enclosed by braces { } and contains the code
             * Later in the year, we'll talk about more return types, access modifiers and parameters */

            // Example:

            void ExampleMethod() // The return type is 'void', method name is in PascalCase, parenthesis required
            {
                // This is the body of the method
                // Your code goes in here

                Console.WriteLine("I am an example Method"); // see?
            }


            // METHODS: calling a method

            /* The place for methods is at the BOTTOM of your code
             * This is just a convention, but keeps your code from being cluttered
             * When you need the code in your method, you can CALL it */

            // Example:

            string greeting1 = "Hi!"; // variables for example
            string greeting2 = "Ho!";
            string whoAmI = "Santa";

            Greeter(); // this is how you CALL the method named Greeter() declared at the bottom

            void Greeter() // a method is declared at the BOTTOM
            {
                if (whoAmI != "Santa")
                {
                    Console.WriteLine(greeting1);
                }
                else
                {
                    Console.WriteLine($"{greeting2}, {greeting2}, {greeting2}");
                }
            }

            /* You can also call a method inside of itself
             * This is called RECURSION */

            int number; // just for example purposes

            void RecursiveExample()
            {
                Console.WriteLine("Please enter a number.");
                number = int.Parse(Console.ReadLine());
                Console.WriteLine("Checking number...");

                if (number == 3)
                {
                    Console.WriteLine("Three!");
                }
                else
                {
                    Console.WriteLine("Number is not 3!");
                    RecursiveExample();
                }
            }

            #endregion

            #endregion



            #region B. Scripting 3 and 4 cheat sheet
            // type conversion
            // operators
            // randoms
            // for loop and (do-)while loop
            // modulo
            // arrays
            // foreach loop

            #region 1. Type Conversion

            /*** TYPE CONVERSION ***/
            // - int.Parse()
            // - int.TryParse()
            // - .ToString()

            /* Type conversion means changing a variable type to another variable type
             * For example, changing text (string type) inton numbers (int type)
             * For example, this is useful for turning user input (which is text) into integers
             * Then you can use comparison operators like 'greater than' or math, which you can't do with text */


            // TYPE CONVERSION: int.Parse()

            // int.Parse() is an easy way to change strings into integers
            // It has no failsafe, it will try to convert any input into an integer
            // But if the input is not valid, you will get an error and your programme will crash

            // An example
            string inputForParsing;
            int output;

            Console.WriteLine("please enter age");
            inputForParsing = Console.ReadLine();

            output = int.Parse(inputForParsing); // You could also do output = int.Parse(Console.ReadLine())

            Console.WriteLine("Your output is: {0}", output);


            // TYPE CONVERSION: int.TryParse()

            // int.TryParse() is a way to parse strings to integers but with a check built in
            // Where int.Parse() will give you an error when the input is not valid
            // int.TryParse() will return true or false depending if the input is valid
            //      - if the input it valid, it returns true AND parses the input to an integer
            //      - if the input is not valid, it returns false

            // Example time, we'll use the same variables as with the int.Parse() example
            // First I'll show you that it returns true or false depending on the input

            inputForParsing = "123";
            Console.WriteLine(int.TryParse(inputForParsing, out output)); // this will write TRUE to the screen

            inputForParsing = "Hi!";
            Console.WriteLine(int.TryParse(inputForParsing, out output)); // this will write FALSE to the screen

            //Now let's see it in use with an if-statement
            inputForParsing = Console.ReadLine();

            if (int.TryParse(inputForParsing, out output))
            {
                Console.WriteLine("Succesfully parsed input");
                Console.WriteLine($"Output is: {output}");
            }
            else
            {
                Console.WriteLine("Could not parse input to an integer");
            }

            // If you use it in a while loop or do-while loop you can repeat it until the input is right

            do // keep asking for input
            {
                Console.Write("Please enter a valid number: ");
                inputForParsing = Console.ReadLine();
            } while (!int.TryParse(inputForParsing, out output)); // while the input is NOT a valid number, using the '!' operator


            // TYPE CONVERSION: .ToString()

            // You can convert numeric variables to strings
            // This can be useful sometimes but we have not covered it
            // Nevertheless, here's how it works:
            int someNumber = 7;
            string convertedNum = someNumber.ToString(); // convertedNum now holds the value "7"


            #endregion



            #region 2. Operators

            /*** OPERATORS ***/
            // - Larger than / smaller than
            // - AND, OR and NOT

            /* Operators are used to evaluate statements (like if statements)
             * We've already seen EQUAL TO (==) in the if-statements session
             * Now we can also check if things are larger or smaller
             * And we can differentiate with AND, OR and NOT */


            // OPERATORS: Larger than / smaller than

            // These check if numbers are larger or smaller than another number
            // Here is how it works, feel free to change the integer values to test different situations
            int num1 = 1000;
            int num2 = 1;

            if (num1 > num2) // If num1 is LARGER THAN num 2
            {
                Console.WriteLine("num1 is LARGER THAN num2");
            }

            if (num1 < num2) // If num1 is SMALLER THAN num 2
            {
                Console.WriteLine("num1 is SMALLER THAN num2");
            }

            // You can also check if numbers are larger/smaller than OR EQUAL TO by adding a '='
            if (num1 >= num2) // If num1 is LARGER THAN OR EQUAL TO num 2
            {
                Console.WriteLine("num1 is LARGER THAN OR EQUAL TO num2");
            }

            if (num1 <= num2) // If num1 is SMALLER THAN OR EQUAL TO num 2
            {
                Console.WriteLine("num1 is SMALLER THAN OR EQUAL TO num2");
            }


            // OPERATORS: AND, OR and NOT

            // The AND operator is used to evaluate two (or more) conditions
            // They BOTH need to be true

            bool a = true;
            bool b = true;

            if (a && b) // if BOTH a and b are TRUE
            {
                // do some cool code
            }

            // This works for every statement that can be evaluated!
            int num3 = 6; // some more intes for the example
            int num4 = 3;
            if (num1 > num2 && num3 > num4) // if BOTH THESE CONDITIONS are TRUE
            {
                // do some cool code
            }

            // The OR operator is used to evaluate if ONE of TWO (or more) conditions are true
            // Only ONE needs to be true in this case
            // example: you can open a chest if your strength score is 18 or higher(smash it) or if you have the key (open the lock)
            int strength = 18;
            bool hasKey = false;

            if (strength >= 18 || hasKey)
            {
                // The chest opens!
                // In this case because your strength is 18 or higher
            }

            // The NOT operator reverses the statement
            // So, using the some of last example:
            if (hasKey) // if you DO have the key 
            {
                // Do stuff with key
            }

            if (!hasKey) // if you DO NOT have the key
            {
                // Do code that should happen if you DO NOT have the key
            }

            #endregion



            #region 3. Randoms
            /*** RANDOMS ***/

            /*     _______
                  /\ o o o\
                 /o \ o o o\_______
                <    >------>   o /|
                 \ o/  o   /_____/o|
                  \/______/     |oo|
                        |   o   |o/
                        |_______|/ */


            /* You can generate random numbers in C#
             * This is mostly useful for game dev purposes
             * For example, simulating a dice roll or coin toss
             * Or adding variation to a damage score in a game
             * There's loads more options,but we'll keep it simple */

            // How to generate a random numbers
            // First, we generate a random object
            // It looks a lot like making a variable
            Random rnd = new Random();

            // We can now use the rnd object to generate random numbers!
            // Let's simulate rolling a 6-sided die
            int d6Roll; // we need an integer to store the random value
            d6Roll = rnd.Next(1, 7); // the second number should be 1 HIGHER than what you need
            Console.WriteLine(d6Roll); // write the result of your roll to the screen

            // Every time you want to generate a new number, you have to repeat the .Next() part
            // Else you get the same result every time
            // Take a look
            d6Roll = rnd.Next(1, 7);
            Console.WriteLine(d6Roll);

            d6Roll = rnd.Next(1, 7);
            Console.WriteLine(d6Roll);

            d6Roll = rnd.Next(1, 7);
            Console.WriteLine(d6Roll);

            // You can generate any number in the integer range
            int someNum = rnd.Next(15, 574); // generates a number between 15-573

            // It also works for other numeric types
            float floaty = rnd.Next(1, 100);
            Console.WriteLine(floaty);

            #endregion



            #region 4. For loop and (do-)while loop
            /*** FOR LOOP AND (DO-)WHILE LOOP ***/
            // - for loop
            // - (do-)while loop


            // THE FOR LOOP
            // A for loop repeats a block of code a given number of times
            // Example:
            int length = 100;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(i); // writes out 0-99 to the screen
            }


            // A for loop consists of the following parts
            //      - For() => this holds the conditions of the loop:
            //          - int i = 0 => 'i' is an integer variabele that exists only within this loop. It starts at 0
            //          - i < length => this means 'while the value of i is lower than the value of length
            //          - i++ => increase i by one
            //      = {do stuff} => This is were your code goes that runs that many times

            // So in short, the loop does this:
            //      - starts with i at 0
            //      - checks if i is still smaller than the other variable
            //      - if it is, run the code in the code block
            //      - increase i by 1
            //      - and repeat

            // You can also use logic in your loop
            int count = 13;
            for (int i = 0; i < count; i++)
            {
                if (i == 13)
                {
                    Console.WriteLine("13 WOOP WOOP 13"); // write this text if the i == 13
                }
                else
                {
                    Console.WriteLine(i); // else, just write the number
                }
            }


            // WHILE LOOP AND DO-WHILE LOOP
            // These loops are very similar
            // They both run as long as a condition is true
            // The difference is when they check:
            //      - The while loop checks the condition first, then runs the code
            //      - the do-while loop runs the code first, then checks the condition
            // This means the code in a do-wile loop runs at least once

            // Examples
            bool doorIsOpen = false;

            while (doorIsOpen)
            {
                Console.WriteLine("The door is open!"); // does not run, since doorIsOpen is false
                // Be careful, this is an infite loop
            }

            do
            {
                Console.WriteLine("The door is open!"); // only runs ONCE, since doorIsOpen is false
            } while (doorIsOpen);

            // The last two loops were badly written, since they don't have an EXIT CONDITION
            // This means that if doorIsOpen was set to true, the loop will run until your laptop runs out of memory
            // We call that an INFINTE LOOP, and you should always avoid them
            // Let's give our two infite loops an exit condition

            while (doorIsOpen)
            {
                Console.WriteLine("The door is open!");
                Console.WriteLine("Would you like to exit the loop or see the message again?");
                Console.WriteLine("If you want to exit the loop, please enter: CLOSE THAT DOOR NOW!");
                // here's our exit condition:
                if (Console.ReadLine() == "CLOSE THAT DOOR NOW!")
                {
                    Console.WriteLine("Jeez, OK...");
                    doorIsOpen = false;
                }
            }

            do
            {
                Console.WriteLine("The door is open!");
                Console.WriteLine("Would you like to exit the loop or see the message again?");
                Console.WriteLine("If you want to exit the loop, please enter: CLOSE THAT DOOR NOW!");
                // here's our exit condition:
                if (Console.ReadLine() == "CLOSE THAT DOOR NOW!")
                {
                    Console.WriteLine("Jeez, OK...");
                    doorIsOpen = false;
                }
            } while (doorIsOpen);

            // Just like always, you can use any sort of condition in these loops
            // A small example about bananas:

            int bunchOfBananas = 10;

            while (bunchOfBananas > 0)
            {
                Console.WriteLine("Do you want to eat a banana?");
                Console.Write("Please enter yes or no: ");
                string answerMe = Console.ReadLine();
                if (answerMe == "yes")
                {
                    Console.WriteLine();
                    Console.WriteLine("NOMNOMNOMHARRRFFLLLBANANARRRRrrrs");
                    Console.WriteLine();
                    bunchOfBananas--;
                }
                else if (answerMe == "no")
                {
                    Console.WriteLine();
                    Console.WriteLine("Sure?");
                    Console.WriteLine("Let me ask again...");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter a valid answer.");
                    Console.WriteLine("I'll ask again...");
                    Console.WriteLine();
                }
            }

            Console.WriteLine("All bananas are gone...");


            // EXTRA: Do-while loop with int.TryParse() and Logical Operators
            // A more advanced implementation of these three techniques combined
            // We'll build a do-while loop that does the following:
            // - It asks the user for a numeric input
            // - It repeats itself when:
            //      - The string input cannot be parsed to an integer
            //      - The parsed integer is smaller than 0
            //      - The parsed integer is larger than, say, 10
            string exampleInput;
            int exampleOutput;

            do
            {
                Console.Write("Please enter a number between 1 - 10: ");
                exampleInput = Console.ReadLine();
                Console.WriteLine();
            } while (!int.TryParse(exampleInput, out exampleOutput) || exampleOutput < 1 || exampleOutput > 10);


            #endregion



            #region 5. Modulo
            /*** % THE % MODULO % OPERATOR % ***/

            // The modulo operator is signified by the percentage sign: %
            // It is a bit of a weird one
            // What it does, is calculate the REMAINDER
            // The syntax is: int remainder = num1 % num2;
            // Basically, it subtracts num2 from num1 as many times as possible and then shows you what's left
            // I'll show you with some examples:
            //  -> 10 % 3 = 1, because:
            //      -> 10 - 3 is 7
            //      -> 7 - 3 is 4
            //      -> 4 - 3 is 1
            //      -> and since you can't subtract 3 from 1, the REMAINDER of 10 % 3 is equal to one
            //  -> 10 % 4 = 2, because 10 - 4 - 4 = 2
            //  -> 10 % 2 = 0, because 10 - 2 - 2 - 2 - 2 - 2 = 0

            // But what will we be using it for?
            //  1. To check if numbers are even or uneven
            //      -> Because for EVERY number, if you do % 2, the answer will be either 1 (uneven number) or 0 (even number)
            //  2. To do something when a number is divisible by another number
            //      -> In that case, the remainder will be 0

            // Code example time
            for (int i = 0; i < 50; i++) // for the numbers 0 through 49
            {
                if (i % 2 == 0) // if the remainder is 0
                {
                    Console.WriteLine("EVEN NUMBER");
                }
                else // in this case: if the remainder is 1
                {
                    Console.WriteLine($"{i} is an uneven number");
                }
            }

            // Another example
            int numberIsDivisible = 10;

            if (numberIsDivisible % 5 == 0)
            {
                Console.WriteLine("Your variable is DIVISIBLE BY 5");
                Console.WriteLine("Which means that (your variable % 5) has 0 remainder ");
            }
            else
            {
                Console.WriteLine("Your variable is NOT divisible by 5");
            }

            #endregion



            #region 6. Arrays
            /*** ARRAYS ***/

            /* ARRAYS are our first look into COLLECTIONS
             * COLLECTIONS are, very simply put, collections of variables
             * In this case, we are talking about ARRAYS
             * The most important thing to remember about arrays is that they are IMMUTABLE
             * That just means that they have a FIXED SIZE
             * Meaning that you can't change how many variables it holds after you intantiate it
             * Another thing to remember is that they hold variables of the same type (all ints, all strings, etc) */

            /* This all sounds a bit weird, so I'll give you some real life examples:
             *      - A parking garage for cars (only holds so many cars at maximum)
             *      - A crate of beer (only holds 24 beers, no more)
             *      - A carton of eggs (only holds 10 or 12 eggs) */

            // Some examples:
            // Let's make an array for integers

            int[] numberArray; // declare array
            numberArray = new int[3]; // initialize with size 3 (meaning it can hold 3 variables)

            // Filling the array by hand
            numberArray[0] = 10;
            numberArray[1] = 20;
            numberArray[2] = 30;

            // An entry in an array is called an ELEMENT
            // As you can see, every ELEMENT of the array has it's own number
            // This number is called the INDEX of the array
            // INDEX ALWAYS STARTS AT 0
            // So the first place of an array has index number 0, the second one has index number 1, and so on
            // A good way to think about this, is a row of houses in a street that have house numbers
            // If you have a street (your array) with 4 houses in it:
            //      - First house in the street has house number 0
            //      - Second house in the street has house number 1
            //      - Third house in the street has house number 2
            //      - Fourth house in the street has house number 3

            // You refer to elements in an array by their index number, like so:
            Console.WriteLine(numberArray[1]); // writing the SECOND ELEMENT in the array to the screen


            // Conveniently, the index numbers of arrays line up with the iterator of the for loop
            // Meaning: index starts at 0, for loop also starts at 0
            // This means you can easily fill an array with a for loop

            // Example:
            string[] playerNames = new string[4]; // making an array of strings with room for 4 elements

            Console.WriteLine("Players, please enter your names.");

            for (int i = 0; i < playerNames.Length; i++) // Here I use .Length to automaticaly get the right size for the array
            {
                Console.Write($"Player {i + 1}, please enter your name: ");
                string yourName = Console.ReadLine();
                Console.WriteLine($"You have entered the name: {yourName}");

                playerNames[i] = yourName; // Storing the user input in the array using the i iterator of the for loop
            }


            // You can also sort arrays, so the elements are sorted from low to high
            int[] numArray = { 6, 4, 118, 24 }; // array with unordered elements

            Array.Sort(numArray); // Sorts from low to high

            Console.WriteLine(numArray[0]);
            Console.WriteLine(numArray[1]);
            Console.WriteLine(numArray[2]);
            Console.WriteLine(numArray[3]);

            // You can also reverse the sorting so it goes from high to low
            Array.Reverse(numArray);

            Console.WriteLine(numArray[0]);
            Console.WriteLine(numArray[1]);
            Console.WriteLine(numArray[2]);
            Console.WriteLine(numArray[3]);

            #endregion



            #region 7. Foreach loop
            /*** FOREACH LOOP ***/

            /* Now its time to introduce our final loop: the foreach loop
             * A for loop runs A GIVEN NUMBER OF TIMES
             * A (do-)while runs UNTIL A CONDITION IS MET
             * A FOREACH LOOP CYCLES TROUGH EVERY ELEMENT IN A COLLECTION */

            // Lets take a look at the syntax:
            foreach (var item in collection)
            {
                // your code goes here!
            }

            // 'var' is the variable type you want to use (strings for string arrays, etc)
            // 'item' is a placeholder variable, you can name it whatever you want
            //      - But it's still smart to use a name that is intuitive!!!
            // 'collection' is the name of your collection, in this case an array

            // Example time! Let's make a fresh array
            string[] japaneseCars = new string[5] { "Nissan", "Toyota", "Mazda", "Honda", "Subaru" };

            foreach (string car in japaneseCars) // for every element (car) in the array japaneseCars:
            {
                Console.WriteLine(car); // write the value of that element to the screen
            }


            // Note that you could also use a for loop to do this
            // Its up to you which one you want to use
            // It depends on the purpose you want to use it for
            // I would advise you to use the one that is most easy to use for the task at hand
            // The main difference is that:
            //      - foreach is ususally easier to use, but has less uses and costs more resources
            //              - This is because every time the loop has run, your computer has to check if there are more elements or not
            //      - For loop is usually harder to use, but more versatile and uses way less resources compared to foreach
            //              -  This is because a for loop runs a predetermined number of times and then it's done, no need to check after every loop

            #endregion




            #endregion
        }
    }
}