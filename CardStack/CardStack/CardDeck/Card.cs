using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    public enum Suit { Diamonds, Hearts, Spides, Clubs };

    class Card
    {
        public string cardname;
        public int rank;
        public Suit Suit;
        public bool IsTrump = false;
        public Card(int rank, Suit suit)
        {
            this.cardname = rank + " " + suit.ToString();
        }
    }
}
