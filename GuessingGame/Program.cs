using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        //EASY METHOD
        public static void easy()
        {
            Random rand = new Random();
            int randNum = rand.Next(1, 11);

            int i = 5;
            while (i >= 0)
                {
                Console.WriteLine("Make your guess");

                string uInput;
                int uGuess;
                uInput = Console.ReadLine();
                //Check if user input is a positive integer
                if (int.TryParse(uInput, out uGuess))
                {
                    if (uGuess > 0)
                    {
                        Console.WriteLine("That's a number!");
                    }
                }
                else
                {
                    Console.WriteLine("That's not a number!");
                }

                if (uGuess == randNum)
                    {
                        Console.WriteLine("You got it right");
                        i = -1;
                    }
                    else {
                        Console.WriteLine("You got it wrong, you have " + i + " guesses left!");
                        i--;
                }
                }

            if (i < 0)
            {
                Console.WriteLine("GAME OVER!");
            }
        }

        //MEDIUM METHOD
        public static void medium()
        {
            Random rand = new Random();
            int randNum = rand.Next(1, 21);

            int i = 3;
            while (i >= 0)
            {
                Console.WriteLine("Make your guess");

                string uInput;
                int uGuess;
                uInput = Console.ReadLine();
                //Check if user input is a positive integer
                if (int.TryParse(uInput, out uGuess))
                {
                    if (uGuess > 0)
                    {
                        Console.WriteLine("That's a number!");
                    }
                }
                else
                {
                    Console.WriteLine("That's not a number!");
                }

                if (uGuess == randNum)
                {
                    Console.WriteLine("You got it right");
                    i = -1;
                }
                else
                {
                    Console.WriteLine("You got it wrong, you have " + i + " guesses left!");
                    i--;
                }
            }

            if (i < 0)
            {
                Console.WriteLine("GAME OVER!");
            }
        }

        //HARD METHOD
        public static void hard()
        {
            Random rand = new Random();
            int randNum = rand.Next(1, 51);

            int i = 2;
            while (i >= 0)
            {
                Console.WriteLine("Make your guess");

                string uInput;
                int uGuess;
                uInput = Console.ReadLine();
                //Check if user input is a positive integer
                if (int.TryParse(uInput, out uGuess))
                {
                    if (uGuess > 0)
                    {
                        Console.WriteLine("That's a number!");
                    }
                }
                else
                {
                    Console.WriteLine("That's not a number!");
                }

                if (uGuess == randNum)
                {
                    Console.WriteLine("You got it right");
                    i = -1;
                }
                else
                {
                    Console.WriteLine("You got it wrong, you have " + i + " guesses left!");
                    i--;
                }
            }

            if (i < 0)
            {
                Console.WriteLine("GAME OVER!");
            }
        }
        static void Main(string[] args)
        {
            string uLevel;

            Console.WriteLine("Kindly input level (easy, medium, hard): ");
            uLevel = Console.ReadLine();

            if (uLevel == "easy")
            {
                easy();
            }
            else if (uLevel == "medium")
            {
                medium();
            }
            else if (uLevel == "hard")
            {
                hard();
            }
            else
            {
                Main(args);
            }

            Console.ReadLine();
        }
    }
}
