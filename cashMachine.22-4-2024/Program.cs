using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace cashMachine._22_4_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //values
            AccountObject Account = new AccountObject();

            int pinCodeInput;
            int tries;

            //cash
            int[] inHandCash = new int[] { 5, 10, 20, 50, 100 };

            // note (5)
            inHandCash[0] = 0;

            // note (10)
            inHandCash[1] = 0;

            // note (20)
            inHandCash[2] = 0;

            // note (50)
            inHandCash[3] = 0;

            // note (100)
            inHandCash[4] = 0;


            //code
            tries = 3;
            Console.WriteLine("hi welkom by Your Bank; please enter your pincode: ");
            Open();

            //methods
            void Open()
            {
                pinCodeInput = int.Parse(Console.ReadLine());
                if (pinCodeInput == Account.CorrectPinCode)
                {
                    Console.WriteLine();
                    Console.WriteLine("Interface; what would you like to do?");
                    Interface();
                }
                else if (tries > 0)
                {
                    tries--;
                    Console.WriteLine("wrong pinCode try again: ");
                    Open();
                }
                else
                {
                    Console.WriteLine("you have tried and failed to many times, please go away.");
                }
            }

            void Interface()
            {
                Console.WriteLine("1. withdraw");
                Console.WriteLine("2. deposit");
                Console.WriteLine("3. information");
                Console.WriteLine("4. log Out");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("withdraw; What would you like to do?");
                        Withdraw();
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("deposit; What would you like to do?");
                        Deposit();
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("your currect account value is: " + Account.currentAV);
                        Console.WriteLine("you have " + inHandCash[0] + " 5 euro bill(s)");
                        Console.WriteLine("you have " + inHandCash[1] + " 10 euro bill(s)");
                        Console.WriteLine("you have " + inHandCash[2] + " 20 euro bill(s)");
                        Console.WriteLine("you have " + inHandCash[3] + " 50 euro bill(s)");
                        Console.WriteLine("you have " + inHandCash[4] + " 100 euro bill(s)");
                        Console.WriteLine();
                        Information();
                        break;
                    case 4:
                        Console.WriteLine("logged out successfully");
                        break;
                    default:
                        Console.WriteLine("that is not an option; please try something else: ");
                        Interface();
                        break;
                }
            }
            void Withdraw()
            {
                if (Account.currentAV >= 5)
                {
                    Console.WriteLine("1. withdraw: 5");
                }
                if (Account.currentAV >= 10)
                {
                    Console.WriteLine("2. withdraw: 10");
                }
                if (Account.currentAV >= 20)
                {
                    Console.WriteLine("3. withdraw: 20");
                }
                if (Account.currentAV >= 50)
                {
                    Console.WriteLine("4. withdraw: 50");
                }
                if (Account.currentAV >= 100)
                {
                    Console.WriteLine("5. withdraw: 100");
                }
                Console.WriteLine("6. go back");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        if (Account.currentAV >= 5)
                        {
                            int numberOfNotes = (int)(Account.currentAV / 5);
                            Console.WriteLine($"you can withdraw up to {numberOfNotes} 5 euro bills");
                            Console.WriteLine("how many 5 euro bills do you want?");
                            int wantedAmount = int.Parse(Console.ReadLine());
                            if (wantedAmount <= numberOfNotes)
                            {
                                inHandCash[0] += wantedAmount;
                                Account.AccountWithdraw(wantedAmount * 5);
                                Console.WriteLine("withdraw complete");
                                Console.WriteLine();
                                Console.WriteLine("withdraw; What would you like to do? ");
                                Withdraw();
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("that is not an option; please try something else: ");
                                Withdraw();
                            }
                        } else
                        {
                            Console.WriteLine();
                            Console.WriteLine("that is not an option; please try something else: ");
                            Withdraw();
                        }
                        break;
                    case 2:
                        if (Account.currentAV >= 10)
                        {
                            int numberOfNotes = (int)(Account.currentAV / 10);
                            Console.WriteLine($"you can withdraw up to {numberOfNotes} 10 euro bills");
                            Console.WriteLine("how many 10 euro bills do you want?");
                            int wantedAmount = int.Parse(Console.ReadLine());
                            if (wantedAmount <= numberOfNotes)
                            {
                                inHandCash[1] += wantedAmount;
                                Account.AccountWithdraw(wantedAmount * 10);
                                Console.WriteLine("withdraw complete");
                                Console.WriteLine();
                                Console.WriteLine("withdraw; What would you like to do? ");
                                Withdraw();
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("that is not an option; please try something else: ");
                                Withdraw();
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("that is not an option; please try something else: ");
                            Withdraw();
                        }
                        break;
                    case 3:
                        if (Account.currentAV >= 20)
                        {
                            int numberOfNotes = (int)(Account.currentAV / 20);
                            Console.WriteLine($"you can withdraw up to {numberOfNotes} 20 euro bills");
                            Console.WriteLine("how many 20 euro bills do you want?");
                            int wantedAmount = int.Parse(Console.ReadLine());
                            if (wantedAmount <= numberOfNotes)
                            {
                                inHandCash[2] += wantedAmount;
                                Account.AccountWithdraw(wantedAmount * 20);
                                Console.WriteLine("withdraw complete");
                                Console.WriteLine();
                                Console.WriteLine("withdraw; What would you like to do? ");
                                Withdraw();
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("that is not an option; please try something else: ");
                                Withdraw();
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("that is not an option; please try something else: ");
                            Withdraw();
                        }
                        break;
                    case 4:
                        if (Account.currentAV >= 50)
                        {
                            int numberOfNotes = (int)(Account.currentAV / 50);
                            Console.WriteLine($"you can withdraw up to {numberOfNotes} 50 euro bills");
                            Console.WriteLine("how many 50 euro bills do you want?");
                            int wantedAmount = int.Parse(Console.ReadLine());
                            if (wantedAmount <= numberOfNotes)
                            {
                                inHandCash[3] += wantedAmount;
                                Account.AccountWithdraw(wantedAmount * 50);
                                Console.WriteLine("withdraw complete");
                                Console.WriteLine();
                                Console.WriteLine("withdraw; What would you like to do? ");
                                Withdraw();
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("that is not an option; please try something else: ");
                                Withdraw();
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("that is not an option; please try something else: ");
                            Withdraw();
                        }
                        break;
                    case 5:
                        if (Account.currentAV >= 100)
                        {
                            int numberOfNotes = (int)(Account.currentAV / 100);
                            Console.WriteLine($"you can withdraw up to {numberOfNotes} 100 euro bills");
                            Console.WriteLine("how many 100 euro bills do you want?");
                            int wantedAmount = int.Parse(Console.ReadLine());
                            if (wantedAmount <= numberOfNotes)
                            {
                                inHandCash[4] += wantedAmount;
                                Account.AccountWithdraw(wantedAmount * 100);
                                Console.WriteLine("withdraw complete");
                                Console.WriteLine();
                                Console.WriteLine("withdraw; What would you like to do? ");
                                Withdraw();
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("that is not an option; please try something else: ");
                                Withdraw();
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("that is not an option; please try something else: ");
                            Withdraw();
                        }
                        break;
                    case 6:
                        Console.WriteLine();
                        Console.WriteLine("Interface; what would you like to do?");
                        Interface();
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("that is not an option; please try something else: ");
                        Withdraw();
                        break;
                }
            }

            void Deposit()
            {
                if (inHandCash[0] > 0)
                {
                    Console.WriteLine("1. deposit: 5");
                }
                if (inHandCash[1] > 0)
                {
                    Console.WriteLine("2. deposit: 10");
                }
                if (inHandCash[2] > 0)
                {
                    Console.WriteLine("3. deposit: 20");
                }
                if (inHandCash[3] > 0)
                {
                    Console.WriteLine("4. deposit: 50");
                }
                if (inHandCash[4] > 0)
                {
                    Console.WriteLine("5. deposit: 100");
                }
                Console.WriteLine("6. go back");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        if (inHandCash[0] > 0)
                        {
                            Console.WriteLine($"you have {inHandCash[0]} 5 euro bills");
                            Console.WriteLine("how many 5 euro bills do you want to deposit?");
                            int wantedAmount = int.Parse(Console.ReadLine());
                            if (wantedAmount <= inHandCash[0])
                            {
                                inHandCash[0] -= wantedAmount;
                                Account.AccountDeposit(wantedAmount * 5);
                                Console.WriteLine("deposit complete");
                                Console.WriteLine();
                                Console.WriteLine("deposit; What would you like to do? ");
                                Deposit();
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("that is not an option; please try something else: ");
                                Deposit();
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("that is not an option; please try something else: ");
                            Deposit();
                        }
                        break;
                    case 2:
                        if (inHandCash[1] > 0)
                        {
                            Console.WriteLine($"you have {inHandCash[1]} 10 euro bills");
                            Console.WriteLine("how many 10 euro bills do you want to deposit?");
                            int wantedAmount = int.Parse(Console.ReadLine());
                            if (wantedAmount <= inHandCash[1])
                            {
                                inHandCash[1] -= wantedAmount;
                                Account.AccountDeposit(wantedAmount * 10);
                                Console.WriteLine("deposit complete");
                                Console.WriteLine();
                                Console.WriteLine("deposit; What would you like to do? ");
                                Deposit();
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("that is not an option; please try something else: ");
                                Deposit();
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("that is not an option; please try something else: ");
                            Deposit();
                        }
                        break;
                    case 3:
                        if (inHandCash[2] > 0)
                        {
                            Console.WriteLine($"you have {inHandCash[2]} 20 euro bills");
                            Console.WriteLine("how many 20 euro bills do you want to deposit?");
                            int wantedAmount = int.Parse(Console.ReadLine());
                            if (wantedAmount <= inHandCash[2])
                            {
                                inHandCash[2] -= wantedAmount;
                                Account.AccountDeposit(wantedAmount * 20);
                                Console.WriteLine("deposit complete");
                                Console.WriteLine();
                                Console.WriteLine("deposit; What would you like to do? ");
                                Deposit();
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("that is not an option; please try something else: ");
                                Deposit();
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("that is not an option; please try something else: ");
                            Deposit();
                        }
                        break;
                    case 4:
                        if (inHandCash[3] > 0)
                        {
                            Console.WriteLine($"you have {inHandCash[3]} 50 euro bills");
                            Console.WriteLine("how many 50 euro bills do you want to deposit?");
                            int wantedAmount = int.Parse(Console.ReadLine());
                            if (wantedAmount <= inHandCash[3])
                            {
                                inHandCash[3] -= wantedAmount;
                                Account.AccountDeposit(wantedAmount * 50);
                                Console.WriteLine("deposit complete");
                                Console.WriteLine();
                                Console.WriteLine("deposit; What would you like to do? ");
                                Deposit();
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("that is not an option; please try something else: ");
                                Deposit();
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("that is not an option; please try something else: ");
                            Deposit();
                        }
                        break;
                    case 5:
                        if (inHandCash[4] > 0)
                        {
                            Console.WriteLine($"you have {inHandCash[4]} 100 euro bills");
                            Console.WriteLine("how many 100 euro bills do you want to deposit?");
                            int wantedAmount = int.Parse(Console.ReadLine());
                            if (wantedAmount <= inHandCash[4])
                            {
                                inHandCash[4] -= wantedAmount;
                                Account.AccountDeposit(wantedAmount * 100);
                                Console.WriteLine("deposit complete");
                                Console.WriteLine();
                                Console.WriteLine("deposit; What would you like to do? ");
                                Deposit();
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("that is not an option; please try something else: ");
                                Deposit();
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("that is not an option; please try something else: ");
                            Deposit();
                        }
                        break;
                    case 6:
                        Console.WriteLine();
                        Console.WriteLine("Interface; what would you like to do?");
                        Interface();
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("that is not an option; please try something else: ");
                        Deposit();
                        break;
                }
            }

                void Information()
                {
                Console.WriteLine("Information; what would you like to do?");
                Console.WriteLine("1. go back");

                    int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("Interface; what would you like to do?");
                        Interface();
                        break;
                   default:
                        Console.WriteLine();
                        Console.WriteLine("that is not an option; please try something else: ");
                        Information();
                        break;
                }
            }
        }
    }
}