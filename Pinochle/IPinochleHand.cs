using System.Collections.Generic;
using CardGame;

namespace Pinochle
{
    public interface IPinochleHand : IHand
    {
        Suit.SuitType Trump { get; set; }
        int GetMaxBid();
        int GetMeld();
        List<ICard> PassToBidder(Suit.SuitType trump);
        List<ICard> PassToNonBidder(Suit.SuitType trump);
        int PlayCard(Suit.SuitType trump, List<IHand> cardsPlayed);
        Suit.SuitType SelelctTrump();
    }
}