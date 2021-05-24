﻿using System;
using System.Collections.Generic;
using System.Linq;

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
                if(adding == true)
                {
                    Console.WriteLine("Spelling error, please make sure to specify alphabetical ranks and suits in plural. E.G. three of diamonds");
                }
            }
        }

        public void Shuffle()
        {
            Random rng = new Random();

            //Implementing the Fisher-Yates shuffle method
            int n = deck.Count;
            while(n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card crd = deck[k];
                deck[k] = deck[n];
                deck[n] = crd;
            }
            //deck = this.deck.OrderBy(c => rng.Next()).ToList();
        }

        public void Draw()
        {
            Console.WriteLine("You drew this card: " + (deck[deck.Count - 1]).Rank + " of " + (deck[deck.Count - 1]).Suit);
            deck.RemoveAt(deck.Count - 1);
        }
    }
}
