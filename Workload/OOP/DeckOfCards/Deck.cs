using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Deck
    {
        //=============== Attributes up top ================//
        public List<Card> Cards = new List<Card>();

        //================= Constructor(s) =================//
        public Deck()
        {
            int[] cardVals = new int[13] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            string[] suitTypes = new string[] { "Spades", "Clubs", "Hearts", "Dimonds" };
            foreach (string suit in suitTypes)
            {
                foreach (int val in cardVals)
                {
                    // Card card = new Card(suit, val);
                    Cards.Add(new Card(suit, val));
                }
            }
        }
        //==================== Methods =====================//
        public void shuffle()
        {
            List<Card> ShuffledDeck = new List<Card>();
            Random rand = new Random();
            Card ChoosenCard;
            for (int i = 0; i < 52; i++)
            {
                do
                {
                    ChoosenCard = Cards[rand.Next(0, 52)];
                } while (ShuffledDeck.Contains(ChoosenCard));
                ShuffledDeck.Add(ChoosenCard);
            }
            Cards = ShuffledDeck;
        }
        public void reset()
        {
            // will re-initiate it 
            // will trigger the shuffle
        }
        public Card Deal()
        {
            Card DeltCard = Cards[0];
            Cards.RemoveAt(0);
            return DeltCard;
        }
    }
}