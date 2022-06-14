using System;

namespace GuyClassPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            Guy player = new Guy() { Name = "The player", Cash = 100 };

            Betting.WelcomePlayer();
            player.WriteMyInfo();

            Console.WriteLine("How much would you like to bet? ");
            string howMuch = Console.ReadLine();
            if (int.TryParse(howMuch, out int amount))
            {
                int pot = 2 * amount;
                int Winnings = Betting.DoubleOrNothing(amount);
            }

        }
    }
}
