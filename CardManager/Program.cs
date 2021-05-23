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

            Console.WriteLine("A new deck has been created.");
            string command = "";

            while (command != "exit")
            {
                Console.WriteLine("Enter a command");
                command = Console.ReadLine().ToLower();
                switch (command)
                {
                    case "options":
                        Console.WriteLine("'shuffle' - shuffles the stack");
                        Console.WriteLine("'view' - displays all cards in the stack");
                        Console.WriteLine("'add' - add another card to the deck");
                        Console.WriteLine("'remove' - remove a card from the deck");
                        Console.WriteLine("'reset' - resets to a new deck");
                        Console.WriteLine("'exit' - terminates the program");
                        Console.WriteLine("'peek' - peeks at the top card on the stack");
                        break;
                    case "shuffle":

                        Console.WriteLine("");
                        break;
                    case "view":
                        PrintDeck(deck);
                        break;
                }
            }
        }

        static void PrintDeck(Deck deck)
        {

        }
    }
}
