namespace scriptingtest2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region question1
            int[] nums = new int[100];
            int random;
            int good = 0;
            int bad = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                Random rnd = new Random();
                random = rnd.Next(1, 21);
                nums[i] = random;
                if (nums[i] > 10)
                {
                    good += 1;
                } else
                {
                    bad += 1;
                }
            }
            Console.WriteLine($"good: {good} + bad: {bad}");

            #endregion
        }
    }
}