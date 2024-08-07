using System;

namespace dnd_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int targetToHit;
            int modifier;
            int ans;
            string advantageDisadvantage;

            ACDC();

            void ACDC()
            {
                Console.WriteLine("What is the AC/DC?");
                targetToHit = ReadIntInput();
                Console.WriteLine("What is the modifier?");
                modifier = ReadIntInput();
                AdvantageOrDisadvantage();
                ans = targetToHit - modifier;
                double probability = CalculateProbability(ans);
                probability = AdjustProbability(probability, advantageDisadvantage);
                Console.WriteLine($"The attack roll has a {probability * 100:F2}% chance of success");
                Console.WriteLine();
                ACDC();
            }

            void AdvantageOrDisadvantage()
            {
                Console.WriteLine("Is it with advantage, disadvantage, or neither? (enter adv, dis, or *anything*)");
                advantageDisadvantage = Console.ReadLine();
            }

            double CalculateProbability(int target)
            {
                double probability = (21.0 - target) / 20.0;
                if (probability > 0.95) probability = 0.95;
                if (probability < 0.05) probability = 0.05;
                return probability;
            }

            double AdjustProbability(double baseProbability, string advDis)
            {
                if (advDis == "adv")
                {
                    return 1 - Math.Pow(1 - baseProbability, 2);
                }
                else if (advDis == "dis")
                {
                    return Math.Pow(baseProbability, 2);
                }
                else
                {
                    return baseProbability;
                }
            }

            int ReadIntInput()
            {
                while (true)
                {
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out int result))
                    {
                        return result;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                    }
                }
            }
        }
    }
}
