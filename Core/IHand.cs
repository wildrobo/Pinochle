using System.Collections.Generic;

namespace CardGame
{
    public interface IHand
    {
        List<ICard> Cards { get; set; }
        List<ICard> KnownCardsPlayed { get; set; }
        Player Player { get; set; }
        void Sort();
        bool Contains(List<ICard> cardsToMatch);


    }
}