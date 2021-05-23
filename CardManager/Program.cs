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

            Console.WriteLine("Enter 'options' for help");
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
                    case "sort":
                        deck.Sort();
                        Console.WriteLine("Deck has been sorted in ascending order");
                        break;
                    case "reset":
                        deck.CreateDeck();
                        break;
                }
            }
        }

        static void PrintOptions()
        {
            Console.WriteLine("'shuffle' - shuffles the deck");
            Console.WriteLine("'view'    - displays all cards in the deck");
            Console.WriteLine("'add'     - add another card to the deck");
            Console.WriteLine("'sort'    - sorts the deck in ascending order");
            Console.WriteLine("'reset'   - resets to a new deck");
            Console.WriteLine("'exit'    - terminates the program");
        }
    }
}
