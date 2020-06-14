using System.Collections.Generic;
using System;

namespace DeckOfCards
{
    public class Player
    {
        public string Name;
        public List<Card> hand;
        public Player(string name)
        {
            Name = name;
            hand = new List<Card>(); 
        }
        public Card draw(Deck cards)
        {
            Card drawOne = cards.dealTopCard();
            hand.Add(drawOne);
            Console.WriteLine($"{drawOne.stringVal}, {drawOne.suit}, {drawOne.val}");
            return drawOne;
        }
        public Card discard(int idx)
        {
            if(idx >= 0 && idx < hand.Count)
            {
                Card toBeDiscarded = hand[idx];
                // hand.RemoveAt(idx);
                hand.Remove(toBeDiscarded);
                Console.WriteLine($"Discarding   {toBeDiscarded.stringVal}");
                return toBeDiscarded;

            }else{
                Console.WriteLine("Count your cards again");
                return null;
            }
        }
    }
}
