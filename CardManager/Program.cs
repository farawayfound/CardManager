using System;
using CardManager.Models;

namespace CardManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Card Manager. Press any key to create a deck of cards");
            Console.ReadKey();
            Console.WriteLine();
            var deck = new Deck();
            PrintOptions();
            string command = "";
            while (command != "exit")
            {
                Console.WriteLine("Enter a command or 'h' for help");
                command = Console.ReadLine().ToLower();
                switch (command)
                {
                    case "h":
                        PrintOptions();
                        break;
                    case "s":
                        deck.Shuffle();
                        Console.WriteLine("Deck has been randomly shuffled");
                        break;
                    case "v":
                        deck.View();
                        break;
                    case "a":
                        deck.AddCard();
                        break;
                    case "d":
                        deck.Draw();
                        break;
                    case "r":
                        deck.CreateDeck();
                        break;
                    default:
                        Console.WriteLine("Enter 'options' for list of commands");
                        break;
                }
            }
        }

        static void PrintOptions()
        {
            Console.WriteLine("'h' - displays list of commands");
            Console.WriteLine("'s' - shuffles the deck");
            Console.WriteLine("'v' - displays all cards in the deck");
            Console.WriteLine("'a' - add another card to the deck");
            Console.WriteLine("'d' - draws the top card out of a deck");
            Console.WriteLine("'r' - resets to a new deck");
            Console.WriteLine("'x' - terminates the program");
        }
    }
}
