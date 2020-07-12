using System;

namespace NumberGuesser
{
    class Program
    {
        const string appName = "Number Guesser";
        const string appVersion = "1.0.0";
        const string appAuthor = "faraj#1337 and Quamozos#6514";
        static Random random = new Random();
        
        // choose a point method
        static void Main(string[] args)
        {
            SetTitle();
            // username question 
            Console.WriteLine("What is your name?");
            // user input name
            string inputName = Console.ReadLine();

            Console.WriteLine($"Hello {inputName}, let's play a game...");

            while (true)
            {
                int correctNumber = random.Next(1, 10);

                int guess = 0;
                // guess number
                Console.WriteLine("Guess a number between 1 and 10");

                // not correct
                while (guess != correctNumber)
                {
                    // get user input
                    string input = Console.ReadLine();

                    // make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        // randomly color
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        // tell user it's not a number
                        Console.WriteLine("Please enter an actual number");
                        Console.ResetColor();
                        continue;
                    }


                    // cast to int and put in guess
                    guess = int.Parse(input);
                    if (guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        // wrong number reply
                        Console.WriteLine("Wrong number, please try again");
                        Console.ResetColor();

                    }

                }
                Console.ForegroundColor = ConsoleColor.DarkBlue;

                // correct number reply
                Console.WriteLine("You are CORRECT!!!");
                Console.ResetColor();


                // ask to play again
                Console.WriteLine("Play Again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();

                if (answer != "Y") return;
                Console.ReadKey();
            }
        }

        static void SetTitle()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            // app info thing bruhh
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }
    }
}
