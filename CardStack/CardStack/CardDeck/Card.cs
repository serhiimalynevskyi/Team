using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    public enum Suit { Diamonds, Hearts, Spides, Clubs };

    class Card
    {
        public string cardname;
        public Card(int rank, Suit suit)
        {
            this.cardname = rank + suit.ToString();
        }
    }
}
