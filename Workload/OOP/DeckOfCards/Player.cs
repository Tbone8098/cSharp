using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Player
    {
        //=============== Attributes up top ================//
        public string Name;
        public List<Card> Hand = new List<Card>();

        //================= Constructor(s) =================//
        public Player(string name)
        {
            Name = name;

        }
        //==================== Methods =====================//
        public void Draw(Deck deck)
        {
            Card DeltCard = deck.Deal();
            Hand.Add(DeltCard);
        }
        public Card Discard(int CardIndex)
        {
            Card CardToDiscard = Hand[CardIndex];
            Hand.RemoveAt(CardIndex);
            return CardToDiscard;
        }
    }
}