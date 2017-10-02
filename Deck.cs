using System;
using System.Collections.Generic;


namespace deck_of_CardsNEW
{
    public class deck
    {
        private List<cardClass> cards;

        public deck()
        {
            Reset();
        }

        public cardClass Deal()
        {
            if(cards.Count > 0)
            {
                cardClass temp = cards[0];
                cards.RemoveAt(0);
                return temp;
            }
            return null;
        }

        public deck Shuffle()
        {
            Random rand = new Random();
            for(int i = cards.Count - 1; i > 0; i--)
            {
                int randI = rand.Next(i);
                cardClass temp = cards[randI];
                cards[randI] = cards[i];
                cards[i] = temp;
            }
            return this;
        }

        public deck Reset()
        {
            cards = new List<cardClass>();
            string [] suits = new string[4]{
                "Hearts", "Clubs", "Spades", "Diamonds"
            };
            foreach(string suit in suits)
            {
                for(int val = 1; val <= 13; val++)
                {
                    cards.Add(new cardClass(suit, val));
                }
            }
            return this;
        }
        public override string ToString()
        {
            string info = "";
            foreach(cardClass card in cards)
            {
                info += card + "\n";
            }
            return info;
        }
    }
}