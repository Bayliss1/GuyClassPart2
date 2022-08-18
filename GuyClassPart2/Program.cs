using System;

namespace GuyClassPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating objects to be used in program
            Random random = new Random();
            double odds = 0.75;
            Guy player = new Guy() { Name = "Natalie", Cash = 100 };

            // welcoming the player and listing their information
            Console.WriteLine("Welcome to the Casino, the odds are " + odds);
            player.WriteMyInfo();

            // loop until the player has no money left
            while (player.Cash > 0) 
            {
                // asks player how much to bet and saves value as variable
                Console.WriteLine("How much would you like to bet? ");
                string howMuch = Console.ReadLine();

                // if you enter blank, you exit the while loop
                if (howMuch == "") return;

                // converts user's entry to an integer, and continues if it is successful
                if (int.TryParse(howMuch, out int amount))
                {
                    // uses 'amount' variable in DoubleOrNothing method and stores the return value as 'pot' variable
                    int pot = DoubleOrNothing(amount);
                    player.Cash += pot;
                }
                player.WriteMyInfo();

                int DoubleOrNothing(int amount)
                {
                    int bet = player.GiveCash(amount);
                    if (bet > 0)
                    {
                        // if roll value is greater than the odds - you win, if lower than the odds - you lose
                        double roll = random.NextDouble();
                        if (roll > odds)
                        {
                            amount = 2 * amount;
                            Console.WriteLine("You win " + amount, " bucks.");
                        }
                        else
                        {
                            amount = 0;
                            Console.WriteLine("Bad luck, you lose.");
                        }
                        return amount;
                        // returns value of 0 if you lose or 2* amount bet if you win (to the if nested statement)
                    }
                    // returns value of 0 if you lose or 2* amount bet if you win (to the else statement)
                    return amount;
                }

                // if the player runs out of money, this message prints
                if (player.Cash == 0)
                {
                    Console.WriteLine("The house always wins!");
                }
            }
        }
    }
}
