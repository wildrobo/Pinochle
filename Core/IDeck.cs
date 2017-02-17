using System.Collections.Generic;

namespace CardGame
{
    public interface IDeck
    {
        List<Card> Cards { get; set; }

        void Shuffle();
   
        void Initialize();
        List<Hand> Deal(int numberOfHands, int numberOfCardsPerHand);

    }
}