using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuyClassPart2
{
    public class Betting
    {
        Random random = new Random();
        static double odds = 0.75;

        public static void WelcomePlayer()
        {
            Console.WriteLine("Welcome to the Casino, the odds are " + Betting.odds);
        }

        public static int DoubleOrNothing(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(amount + " isn't a valid amount at this casino.");
                return 0;
            }
            if (amount < Cash)
            {
                Console.WriteLine("You cannot afford to bet this much.");
                return 0;
            }
            else if (amount >= Cash)
            {
                double roll = random.NextDouble();
                if (roll <= odds)
                {

                }
            }
        }
        
    }
}
