using System.Collections.Generic;

namespace deck_of_CardsNEW
{
    public class player
    {
        public string name;
        private List<cardClass> hand;

        public player(string i)
        {
            hand = new List<cardClass>();
            name = i;
        }

        public void drawfrom(deck currentDeck)
        {
            hand.Add(currentDeck.Deal());
        }

        public cardClass discard(int i)
        {
            cardClass temp = hand[i];
            hand.RemoveAt(i);
            return temp;
        }
    }
}