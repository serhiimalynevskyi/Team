using CardGame;
using CardGame.Game;
using System;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CardDeck");
            CardDeckManager CSM = new CardDeckManager();
            //CSM.Output();
            Game_ game = new Game_();
            game.Run();
            Console.ReadLine();
        }
    }
}
