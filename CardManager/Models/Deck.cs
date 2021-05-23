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
        private List<Card> cards;
        private enum Suits { clubs, diamonds, hearts, spades}
        private Random random = new Random();

        // C o n s t r u c t o r s
        public Deck()
        {
            CreateDeck();
        }

        // M e t h o d s
        public void CreateDeck()
        {
            var suites = new List<string>();
            suites.Add("Club");
            suites.Add("Diamond");
            suites.Add("Heart");
            suites.Add("Spade");

            
        }


    }
}
