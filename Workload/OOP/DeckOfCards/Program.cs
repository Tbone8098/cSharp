using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck Deck1 = new Deck();
            Deck Deck2 = new Deck();
            Deck1.shuffle();
            Player Tyler = new Player("Tyler");
            Player Kendal = new Player("Kendal");
            Tyler.Draw(Deck1);
            Kendal.Draw(Deck2);
            Tyler.Draw(Deck1);
            Kendal.Draw(Deck2);
            Tyler.Draw(Deck1);
            Kendal.Draw(Deck2);
            Tyler.Draw(Deck1);
            Kendal.Draw(Deck2);
            Tyler.Draw(Deck1);
            Kendal.Draw(Deck2);
            Tyler.Discard(3);
        }
    }
}
