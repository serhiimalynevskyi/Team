using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    class CardDeckManager
    {
        public void Initializer(List<Card> CardList)
        {
            for(int i = 0; i < 4; i++)
            {
                for(int ii = 6; ii <= 14; ii++)
                {
                    Card card = new Card(ii, (Suit)i);
                    CardList.Add(card);
                }
            }
        }

        public void Output(List<Card> CardList)
        {
            foreach(var e in CardList)
            {
                Console.WriteLine(e.cardname);
            }
        }
    }
}
