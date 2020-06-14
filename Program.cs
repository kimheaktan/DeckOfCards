using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck KimDeck = new Deck();            
            // KimDeck.printAll();
            KimDeck.shuffle();
            // foreach (Card item in KimDeck.cards)
            // {
            //     KimDeck.printAll();
            // }
            Player Kim = new Player("Kim");
            Kim.draw(KimDeck);
            Kim.draw(KimDeck);
            Kim.draw(KimDeck);
            Kim.draw(KimDeck);
            Kim.draw(KimDeck);
            Kim.discard(2);
            


        }
    }

}
