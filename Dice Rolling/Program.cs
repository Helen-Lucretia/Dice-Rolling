using System;

namespace Dice_Rolling
{
    class Program
    {
        public static int Rolling(int sides)
        {
            Random ran = new Random();
            int dice = ran.Next(1, sides + 1);
            return dice;
        }
        public static string GameMessage(int die1, int die2)
        {
            int total = die1 + die2;
            if (total == 2)
            {
                return "Snake Eyes & Craps";
            }
            if (total == 3)
            {
                return "Ace Deuce & Craps";
            }
            if (total == 12)
            {
                return "Box Cars & Craps";
            }
            if (total == 7 || total == 11)
            {
                return "Winner!";
            }

            return $"{die1}, {die2}";
        } 

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Casino!");

            bool roll = true;
            while (roll)
            {
                Console.Write("\nHow many sides should the die have? ");
                int sides = Int32.Parse(Console.ReadLine());
                int die1 = Rolling(sides);
                int die2 = Rolling(sides);
                int total = die1 + die2;

                Console.WriteLine("You rolled a " + die1 + " and a " + die2 + " ( " + total + " total)");
                Console.WriteLine(GameMessage(die1,die2));
               

                //ask user if they'll like to play again.
                Console.Write("\nWould you like to roll again?(y/n) ");
                string option = Console.ReadLine();
                //if statement to take in users option
                if(option == "n" || option == "N")
                {
                    Console.WriteLine("Thanks for playing!!");
                }
                else if(option == "y" || option == "Y" )
                {
                    Console.WriteLine();
                    continue;
                }
                break;
            }
            
        }
    }
}
