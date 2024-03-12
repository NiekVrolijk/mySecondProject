namespace Logic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. &
            //2. when both parts are true / they're used in if statments
            //3. 
            // A | B | C
            // 0 | 0 | 0
            // 0 | 1 | 0
            // 1 | 0 | 0
            // 1 | 1 | 1
            //4. |
            //5. when 1 or both parts are true / they're used in if statments
            //6.
            // A | B | C
            // 0 | 0 | 0
            // 0 | 1 | 1
            // 1 | 0 | 1
            // 1 | 1 | 1
            //7. !
            //8. when you want something to be false for something else to happen / they're used in if statments
            //9.
            bool a = false;
            bool b = false;
            bool c = false;
            //9.1.
            if (!b) { c = true; };
            //9.2.
            if (a && !b) { c = true; };
            //9.3.
            if (c) { c = false; };
            //10
            bool hasFuel = true;
            bool hasElectricity = false;
            bool canDrive = false;

            if ((hasFuel && !hasElectricity) || (!hasFuel && hasElectricity)) { canDrive = true; };
            Console.WriteLine(canDrive);
        }
    }
}