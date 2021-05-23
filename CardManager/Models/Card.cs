using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardManager.Models
{
    public class Card
    {
        // F i e l d s  &  P r o p e r t i e s
        public int Value { get; private set; }
        public string Suit { get; private set; }

        // C o n s t r u c t o r s
        public Card(int value, string suit)
        {
            Value = value;
            Suit = suit;

        }

        // M e t h o d s
        public string ReadCard()
        {
            return $"{Value} of {Suit}";
        }
    }
}
