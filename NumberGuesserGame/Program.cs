using System;

namespace NumberGuesserGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Jacob Hensley";
            int age = 25;


            Console.WriteLine("My name is: " + name);
            Console.WriteLine("I am " + age + " years old.");
            Console.WriteLine("{0} is {1} years old", name, age);

            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Jacob Hensley";


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();

            Console.WriteLine("Hello, what is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Ok {0}, lets play a game!", inputName);


            static void numberGame() {
                Random num = new Random();

                int correctNumber = num.Next(1, 11);
                int userGuess = 0;

                Console.WriteLine("Try to guess my number between 1 and 10");

                while (userGuess != correctNumber)
                {
                    string inputNumber = Console.ReadLine();

                    userGuess = int.Parse(inputNumber);

                    while (userGuess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("{0} is not the correct answer, try again!", userGuess);
                        Console.ResetColor();
                        userGuess = int.Parse(Console.ReadLine());
                    }
                    if (userGuess == correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Thats Correct! {0}, is the number!", userGuess);
                        Console.ResetColor();
                    }

                    Console.WriteLine("Would you like to play again? (y/n)");

                    string response = Console.ReadLine().ToUpper();

                    if (response != "Y")
                    {
                        Console.WriteLine("Thanks for playing, see you next time!");
                    }
                    else
                    {
                        numberGame();
                    }

                }
            }

            numberGame();

        }
    }
}
