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
            var deck = new Deck();

            string command = "";
            while (command != "exit")
            {
                Console.WriteLine("Enter a command");
                command = Console.ReadLine().ToLower();
                switch (command)
                {
                    case "options":
                        PrintOptions();
                        break;
                    case "shuffle":
                        deck.Shuffle();
                        Console.WriteLine("Deck has been randomly shuffled");
                        break;
                    case "view":
                        deck.View();
                        break;
                    case "add":
                        deck.AddCard();
                        break;
                    case "draw":
                        deck.Draw();
                        break;
                    case "reset":
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
            Console.WriteLine("'shuffle' - shuffles the deck");
            Console.WriteLine("'view'    - displays all cards in the deck");
            Console.WriteLine("'add'     - add another card to the deck");
            Console.WriteLine("'draw'    - draws the top card out of a deck");
            Console.WriteLine("'reset'   - resets to a new deck");
            Console.WriteLine("'exit'    - terminates the program");
        }
    }
}
