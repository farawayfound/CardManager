using System;
using System.Collections.Generic;
using CardManager.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardManager.Models
{
    public class Deck
    {
        // F i e l d s  &  P r o p e r t i e s
        private List<Card> deck;
        private enum Suit { clubs, diamonds, hearts, spades }
        private enum Rank { two = 2, three, four, five, six, seven, eight, nine, ten, jack, queen, king, ace }

        // C o n s t r u c t o r s
        public Deck()
        {
            CreateDeck();
        }

        // M e t h o d s
        public void CreateDeck()
        {
            deck = new List<Card>();
            foreach (Suit s in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank r in Enum.GetValues(typeof(Rank)))
                {
                    deck.Add(new Card(r.ToString(), s.ToString()));
                }
            }
            Console.WriteLine("A fresh deck has been created.");
        }

        public void View()
        {
            foreach (var card in deck)
            {
                Console.WriteLine($"{card.Rank} of {card.Suit}");
            }
            Console.WriteLine();
        }

        public void AddCard()
        {
            bool adding = true;
            while (adding == true)
            {
                Console.WriteLine("enter alphabetical rank");
                string rank = Console.ReadLine().ToLower();
                Console.WriteLine("enter suit");
                string suit = Console.ReadLine().ToLower();
                foreach (Rank r in Enum.GetValues(typeof(Rank)))
                {
                    if (rank == r.ToString())
                    {
                        foreach (Suit s in Enum.GetValues(typeof(Suit)))
                        {
                            if (suit == s.ToString())
                            {
                                Card newCard = new Card(r.ToString(), s.ToString());
                                deck.Add(newCard);
                                Console.WriteLine($"One {rank} of {suit} has been added");
                                adding = false;
                                break;
                            }
                        }
                        break;
                    }
                }
            }
        }

        public void Shuffle()
        {
            Random random = new Random();
            deck = this.deck.OrderBy(c => random.Next()).ToList();
        }

        public void Sort()
        {
            deck = this.deck.OrderBy(c => c.Suit).ThenBy(r => r.Rank).ToList();
        }
    }
}
