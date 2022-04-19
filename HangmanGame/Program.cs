using System;
using Hangman.Core.Game;

namespace HangmanGameConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor oldColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(10, 2);
            Console.Write("Welcome to Hangman!!");
            string[] listwords = new string[20];
            listwords[0] = "Congratulations";
            listwords[1] = "Innovation";
            listwords[2] = "Technology";
            listwords[3] = "Change";
            listwords[4] = "Tea";
            listwords[5] = "Collaboration";
            listwords[6] = "Catalyst";
            listwords[7] = "New";
            listwords[8] = "Keyboard";
            listwords[9] = "Power";
            listwords[10] = "Development";
            listwords[11] = "Social";
            listwords[12] = "Physically";
            listwords[13] = "Samsung";
            listwords[14] = "Family";
            listwords[15] = "Spirit";
            listwords[16] = "Visual";
            listwords[17] = "Learning";
            listwords[18] = "teach";
            listwords[19] = "influence";


            var hangman = new HangmanGame();
            hangman.Run();
            string mysteryWord = listwords[hangman];
            char[] guess = new char[mysteryWord.Length];
            Console.Write("Please enter your guess: ");
            Console.ForegroundColor = oldColor;

            for (int i = 0; i < mysteryWord.Length; i++)
                guess[i] = mysteryWord[i];

            while (true)
            {
                Char playerGuess =char.Parse(Console.ReadLine());
                for (int i = 0; i < mysteryWord.Length; i++)
                {
                    if (playerGuess == mysteryWord[i])
                        guess[i]=playerGuess;
                }
            }



            Console.SetCursorPosition(20, 25);
            Console.WriteLine("Thank you for playing");
            Console.ReadLine();
        }
    }
}
