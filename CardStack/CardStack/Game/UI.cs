using CardGame.Game;
using System;
using System.Collections.Generic;

namespace CardGame
{
    class UI
    {

        public Card Step(List<Card> Hand) // Hand 6 cards
        {
            int a = 0;
            foreach(var card in Hand)
            {
                Console.WriteLine(a + card.cardname);
            }
            string InPut = Console.ReadLine();
            int i = Convert.ToInt32(InPut);
            return Hand[i];
        }

    }
}