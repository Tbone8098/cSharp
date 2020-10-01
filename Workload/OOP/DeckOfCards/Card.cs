using System;

namespace DeckOfCards
{
    class Card
    {
        //=============== Attributes up top ================//
        public string stringVal;
        public string Suit;
        public int Val;
        //================= Constructor(s) =================//
        public Card(string suit, int val)
        {
            stringVal = val + " of " + suit;
            Suit = suit;
            Val = val;

        }
        //==================== Methods =====================//
    }
}