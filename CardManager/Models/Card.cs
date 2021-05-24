﻿namespace CardManager.Models
{
    public class Card
    {
        // P r o p e r t i e s
        public string Rank { get; private set; }
        public string Suit { get; private set; }

        // C o n s t r u c t o r s
        public Card(string rank, string suit)
        {
            Rank = rank;
            Suit = suit;
        }

        // M e t h o d s
    }
}
