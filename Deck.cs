using System.Collections.Generic;
using System;
namespace DeckOfCards
{
    public class Deck
    {
        public List<Card> cards;
        public string[] ranks ={"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
        public string[] suits ={"Spades", "Clubs", "Diamonds", "Hearts"};
        public Deck()
        {
            newDeck();
        }

        public List<Card> newDeck()
        {
            cards = new List<Card>();
            for( int i = 0; i < suits.Length; i++)
            {
                for( int j = 0; j < ranks.Length; j++)
                {
                    Card newCard = new Card(ranks[j], suits[i], j+1);
                    cards.Add(newCard);
                }
            }
            return cards ;
        }
        public void printAll()
        {
            foreach(Card card in cards)
            {
                Console.WriteLine($"This is {card.stringVal} of {card.suit} with a value of {card.val}");
            }
        }
        public Card dealTopCard()
        {
            Card topCard = cards[0];
            cards.RemoveAt(0);
            return topCard;
        }

        public void reset()
        {
            newDeck();
        }

        public List<Card> shuffle()
        {
            Random Rand = new Random();
            for (int i = 0; i <cards.Count ; i++)
            {
                Card temp = cards[i];
                int RandomIdx = Rand.Next(cards.Count);

                cards[i] = cards[RandomIdx];
                cards[RandomIdx] = temp;
            }
            return cards;
        }
    }
}