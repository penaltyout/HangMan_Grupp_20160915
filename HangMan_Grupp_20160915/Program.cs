using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan_Grupp_20160915
{
    class Program
    {
        static string yourName;
        static int totalGuesses;
        static string difficultyLevel;
        static string word;

        static void HangmanStart()
        {
            Console.Write("Would you like to play? (Y/N): ");
            string yesOrNo = Console.ReadLine();

            switch (yesOrNo.ToUpper())
            {
                case "Y":
                    EnterYourName();
                    DifficultyLevel();
                    GameEngine();
                    break;
                case "N":
                    Console.Clear();
                    Console.WriteLine("You are always welcome back. Bye for now!");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please choose a valid letter.");
                    Console.WriteLine();
                    HangmanStart();
                    break;
            }
        }

        static void EnterYourName()
        {
            do
            {
                Console.Clear();
                Console.Write("Please enter your name to start (more than 2 characters): ");
                yourName = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Welcome " + yourName + ", good luck!");
                Console.WriteLine();
                Console.Clear();
            } while (yourName.Length < 3);
        }

        static void DifficultyLevel()
        {
            Console.WriteLine("What level do you want to play? ");
            Console.WriteLine();
            Console.WriteLine("1. Easy");
            Console.WriteLine("2. Normal");
            Console.WriteLine("3. Hard");
            Console.WriteLine();

            Console.Write("Please choose your level: ");
            difficultyLevel = Console.ReadLine();
            switch (difficultyLevel)
            {
                case "1":
                    Console.WriteLine();
                    Console.WriteLine("You have chosen 'Easy' level. Please press any key.");
                    Console.ReadKey();
                    Console.Clear();
                    word = "RIA";
                    totalGuesses = 10;
                    break;
                case "2":
                    Console.WriteLine();
                    Console.WriteLine("You have chosen 'Normal' level. Please press any key.");
                    word = "Sofie";
                    totalGuesses = 07;
                    break;

                case "3":
                    Console.WriteLine();
                    Console.WriteLine("You have chosen 'Hard' level. Please press any key.");
                    word = "Sebastian";
                    totalGuesses = 05;
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("You pressed a wrong key.");
                    Console.WriteLine();
                    DifficultyLevel();
                    break;
            }
        }

        static void GameEngine()
        {
            bool isInputWord = true;

            while (isInputWord)
            {
                Console.WriteLine("You have " + totalGuesses + " live(s) left.");
                Console.WriteLine();
                Console.Write("Please guess the word: ");
                string wordToGuess = Console.ReadLine();

                if (wordToGuess == word)
                {
                    Console.WriteLine();
                    Console.WriteLine("Congratulations, " + yourName + "! " + "Your guess was correct. The answer is " + wordToGuess + "!");
                    isInputWord = false;
                    Console.WriteLine();
                    Console.Write("Would you play again? (Y/N): ");
                    string againOrNot = Console.ReadLine();

                    switch (againOrNot.ToUpper())
                    {
                        case "Y":
                            Console.Clear();
                            DifficultyLevel();
                            break;
                        case "N":
                            Console.Clear();
                            Console.WriteLine("You are always welcome back. Bye for now!");
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Please choose a valid letter.");
                            Console.WriteLine();
                            HangmanStart();
                            break;
                    }

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine(wordToGuess + " is a wrong answer. Press any key.");
                    Console.WriteLine();
                    totalGuesses--;
                    //Console.WriteLine("You have " + totalGuesses + " live(s) left.");
                    Console.ReadKey();
                    Console.Clear();

                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("****** Welcome to the ever so delightful game, Hangman! ******");
            Console.WriteLine();
            HangmanStart();
            Console.ReadLine();
        }
    }
}
