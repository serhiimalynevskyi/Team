using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.Game
{
    class Game_
    {
        UI ui = new UI();
        AI ai = new AI();
        List<Card> CardList = new List<Card>();
        public static Suit Trump;

        public Game_()
        {
            Random rnd = new Random();
            Trump = (Suit)rnd.Next(3);
            
        }
        public void Run()
        {
            CardDeckManager carddeck = new CardDeckManager();
            carddeck.Initializer(CardList);
            carddeck.Output(CardList);
            Console.ReadLine();
            
        }
        public List<Card> GiveHand()
        {
            List<Card> Hand = new List<Card>();
            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                Hand.Add(CardList[rnd.Next(36)]);
            }
            return Hand;
        }
        public void Distribution(List<Card> CardlistPlayer, List<Card> CardListAI)
        {
            Card card = ui.Step(CardlistPlayer);
            Card responsecard = ai.Response(card);
        }

    }
}
