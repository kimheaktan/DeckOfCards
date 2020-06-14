namespace DeckOfCards
{
    public class Card
    {
        public string stringVal;
        public string suit; 
        public int val;

        public Card(string newCardVal, string newSuit, int newVal)
        {
            stringVal = newCardVal;
            suit = newSuit;
            val = newVal;
        }
    }
}