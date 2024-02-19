using System.Runtime.InteropServices;

namespace smallGame1
{
    internal class Program
    {
        enum room { bedroom, livingroom, kitchen, basement }
        static void Main(string[] args)
        {
            //var
            int choice = 0;
            bool haveFlashLight = false;
            bool haveKey = false;
            bool haveMeat = false;

            room room;
            room = room.bedroom;

            Console.WriteLine("you wake up, what do you do?");
            BedRoom();

            #region Bedroom
            void BedRoom()
            {
                Console.WriteLine("1. i go on my phone");
                Console.WriteLine("2. look under pillow");
                Console.WriteLine("3. i go to a different room");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("you lose track of time and go to bed :O");
                        Console.WriteLine();

                        Console.WriteLine("you wake up, what do you do?");

                        BedRoom();
                        break;
                    case 2:
                        if (!haveFlashLight)
                        {
                            Console.WriteLine("you see a flashlight and take it");
                            haveFlashLight = true;
                            Console.WriteLine();

                            Console.WriteLine("you got the flashlight, what do you do?");
                        }
                        else
                        {
                            Console.WriteLine("there is nothing there anymore. you put the flashlight back.");
                            haveFlashLight = false;
                            Console.WriteLine();

                            Console.WriteLine("you don't have the flashlight anymore, what do you do?");
                        }
                            BedRoom();
                        break;
                    case 3:
                        Console.WriteLine("what room would you like to go to?");
                        Console.WriteLine("1. stay in bedroom");
                        Console.WriteLine("2. livingroom");
                        Console.WriteLine("3. kitchen");
                        Console.WriteLine("4. basement");

                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("you are still in your bedroom. What would you like to do?");
                                BedRoom();
                                break;
                            case 2:
                                Console.WriteLine("you are now in your livingroom. What would you like to do?");
                                LivingRoom();
                                break;
                            case 3:
                                Console.WriteLine("you are now in your kitchen. What would you like to do?");
                                Kitchen();
                                break;
                            case 4:
                                Console.WriteLine("you are now in your basement. What would you like to do?");
                                Basement();
                                break;
                            default:
                                Console.WriteLine("not a room. What would you like to do?");
                                BedRoom();
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("that is not a choice. What would you like to do?");
                        BedRoom();
                        break;
                }
            }
            #endregion

            #region Livingroom
            void LivingRoom()
            {
                Console.WriteLine("1. walk around and do nothing");
                Console.WriteLine("2. try to leave");
                Console.WriteLine("3. i go to a different room");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("you do nothing for a while :O");
                        Console.WriteLine();
                        Console.WriteLine("what would you like to do now?");

                        LivingRoom();
                        break;
                    case 2:
                        if (!haveKey)
                        {
                            Console.WriteLine("you try to leave his house but the door is locked.");
                            Console.WriteLine();
                            Console.WriteLine("what would you like to do now?");
                            LivingRoom();
                        }
                        else
                        {
                            if (!haveMeat)
                            {
                                Console.WriteLine("You got out. You are free.");
                            } else
                            {
                                Console.WriteLine("You got out. You are free with your weird meat.");
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("what room would you like to go to?");
                        Console.WriteLine("1. bedroom");
                        Console.WriteLine("2. stay in livingroom");
                        Console.WriteLine("3. kitchen");
                        Console.WriteLine("4. basement");

                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("you are now in your bedroom. What would you like to do?");
                                BedRoom();
                                break;
                            case 2:
                                Console.WriteLine("you are still in your livingroom. What would you like to do?");
                                LivingRoom();
                                break;
                            case 3:
                                Console.WriteLine("you are now in your kitchen. What would you like to do?");
                                Kitchen();
                                break;
                            case 4:
                                Console.WriteLine("you are now in your basement. What would you like to do?");
                                Basement();
                                break;
                            default:
                                Console.WriteLine("not a room. What would you like to do?");
                                LivingRoom();
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("that is not a choice. What would you like to do?");
                        LivingRoom();
                        break;
                }
            }
            #endregion

            #region Kitchen
            void Kitchen()
            {
                Console.WriteLine("1. make something to eat");
                Console.WriteLine("2. look in the fridge");
                Console.WriteLine("3. i go to a different room");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("you make something to eat and eat it :O");
                        Console.WriteLine();
                        Console.WriteLine("what would you like to do now?");

                        Kitchen();
                        break;
                    case 2:
                        if (!haveMeat)
                        {
                            Console.WriteLine("you see a piece of strange meat and take it");
                            haveMeat = true;
                            Console.WriteLine();

                            Console.WriteLine("you got the weird meat, what do you do?");
                        }
                        else
                        {
                            Console.WriteLine("there is no more meat in the fridge. you put the piece of stange meat you took back.");
                            haveMeat = false;
                            Console.WriteLine();

                            Console.WriteLine("you don't have the weird meat anymore, what do you do?");
                        }
                        Kitchen();
                        break;
                    case 3:
                        Console.WriteLine("what room would you like to go to?");
                        Console.WriteLine("1. bedroom");
                        Console.WriteLine("2. livingroom");
                        Console.WriteLine("3. stay in kitchen");
                        Console.WriteLine("4. basement");

                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("you are now in your bedroom. What would you like to do?");
                                BedRoom();
                                break;
                            case 2:
                                Console.WriteLine("you are now in your livingroom. What would you like to do?");
                                LivingRoom();
                                break;
                            case 3:
                                Console.WriteLine("you are still in your kitchen. What would you like to do?");
                                Kitchen();
                                break;
                            case 4:
                                Console.WriteLine("you are now in your basement. What would you like to do?");
                                Basement();
                                break;
                            default:
                                Console.WriteLine("not a room. What would you like to do?");
                                Kitchen();
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("that is not a choice. What would you like to do?");
                        Kitchen();
                        break;
                }
            }
            #endregion

            #region Basement
            void Basement()
            {
                Console.WriteLine("1. i go into the dark");
                Console.WriteLine("2. i go to a different room");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        if (haveFlashLight)
                        {
                            if (haveMeat)
                            {
                                Console.WriteLine("you shine your flashlight into the dark. You see him move into the dark.");
                                Console.WriteLine("you see a key in the dark. As you go to pick it up, you hear him behind you.");
                                haveFlashLight = false;
                                haveMeat = false;
                                Console.WriteLine();
                                Console.WriteLine("you wake up, what do you do?");
                                BedRoom();
                            } else
                            {
                                if (!haveKey)
                                {
                                    Console.WriteLine("you shine your flashlight into the dark. You see him move into the dark.");
                                    Console.WriteLine("you see a key in the dark. You go pick it up.");
                                    haveKey = true;
                                    Console.WriteLine();
                                    Console.WriteLine("what would you like to do now?");
                                    Basement();
                                }
                                else
                                {
                                    Console.WriteLine("you throw your key in the dark. You hear it hit the floor");
                                    haveKey = false;
                                    Console.WriteLine();
                                    Console.WriteLine("what would you like to do now?");
                                    Basement();
                                }
                            }
                        } else
                        {
                            if (haveMeat)
                            {
                                Console.WriteLine("you go into the dark. You hear something move.");
                                haveMeat = false;
                                Console.WriteLine();
                                Console.WriteLine("you wake up, what do you do?");
                                BedRoom();
                            }
                            else
                            {
                                Console.WriteLine("you go into the dark. Hear something. Get scared and go back into the light :O");
                                Console.WriteLine();
                                Console.WriteLine("what would you like to do now?");
                                Basement();
                            }
                        }

                        break;
                    case 2:
                        Console.WriteLine("what room would you like to go to?");
                        Console.WriteLine("1. bedroom");
                        Console.WriteLine("2. livingroom");
                        Console.WriteLine("3. kitchen");
                        Console.WriteLine("4. stay in basement");

                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("you are now in your bedroom. What would you like to do?");
                                BedRoom();
                                break;
                            case 2:
                                Console.WriteLine("you are now in your livingroom. What would you like to do?");
                                LivingRoom();
                                break;
                            case 3:
                                Console.WriteLine("you are now in your kitchen. What would you like to do?");
                                Kitchen();
                                break;
                            case 4:
                                Console.WriteLine("you are still in your basement. What would you like to do?");
                                Basement();
                                break;
                            default:
                                Console.WriteLine("not a room. What would you like to do?");
                                Basement();
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("that is not a choice. What would you like to do?");
                        Basement();
                        break;
                }
            }
            #endregion

        }
    }
}
