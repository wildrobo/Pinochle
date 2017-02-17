using System;
using System.Collections.Generic;
using CardGame;

namespace Pinochle
{
    public class PinochleDeck : Deck, IDeck
    {
        public PinochleDeck()
        {
            Initialize();
        }
        public void Initialize()
        {
            if (Cards.Count != 48)
            {
                Cards.Clear();
                AddCardToDeck(Suit.SuitType.Club, "9", 1);
                AddCardToDeck(Suit.SuitType.Club, "9", 1);
                AddCardToDeck(Suit.SuitType.Club, "10", 2);
                AddCardToDeck(Suit.SuitType.Club, "10", 2);
                AddCardToDeck(Suit.SuitType.Club, "J", 3);
                AddCardToDeck(Suit.SuitType.Club, "J", 3);
                AddCardToDeck(Suit.SuitType.Club, "Q", 4);
                AddCardToDeck(Suit.SuitType.Club, "Q", 4);
                AddCardToDeck(Suit.SuitType.Club, "K", 5);
                AddCardToDeck(Suit.SuitType.Club, "K", 5);
                AddCardToDeck(Suit.SuitType.Club, "A", 6);
                AddCardToDeck(Suit.SuitType.Club, "A", 6);
                AddCardToDeck(Suit.SuitType.Diamond, "9", 1);
                AddCardToDeck(Suit.SuitType.Diamond, "9", 1);
                AddCardToDeck(Suit.SuitType.Diamond, "10", 2);
                AddCardToDeck(Suit.SuitType.Diamond, "10", 2);
                AddCardToDeck(Suit.SuitType.Diamond, "J", 3);
                AddCardToDeck(Suit.SuitType.Diamond, "J", 3);
                AddCardToDeck(Suit.SuitType.Diamond, "Q", 4);
                AddCardToDeck(Suit.SuitType.Diamond, "Q", 4);
                AddCardToDeck(Suit.SuitType.Diamond, "K", 5);
                AddCardToDeck(Suit.SuitType.Diamond, "K", 5);
                AddCardToDeck(Suit.SuitType.Diamond, "A", 6);
                AddCardToDeck(Suit.SuitType.Diamond, "A", 6);
                AddCardToDeck(Suit.SuitType.Heart, "9", 1);
                AddCardToDeck(Suit.SuitType.Heart, "9", 1);
                AddCardToDeck(Suit.SuitType.Heart, "10", 2);
                AddCardToDeck(Suit.SuitType.Heart, "10", 2);
                AddCardToDeck(Suit.SuitType.Heart, "J", 3);
                AddCardToDeck(Suit.SuitType.Heart, "J", 3);
                AddCardToDeck(Suit.SuitType.Heart, "Q", 4);
                AddCardToDeck(Suit.SuitType.Heart, "Q", 4);
                AddCardToDeck(Suit.SuitType.Heart, "K", 5);
                AddCardToDeck(Suit.SuitType.Heart, "K", 5);
                AddCardToDeck(Suit.SuitType.Heart, "A", 6);
                AddCardToDeck(Suit.SuitType.Heart, "A", 6);
                AddCardToDeck(Suit.SuitType.Spade, "9", 1);
                AddCardToDeck(Suit.SuitType.Spade, "9", 1);
                AddCardToDeck(Suit.SuitType.Spade, "10", 2);
                AddCardToDeck(Suit.SuitType.Spade, "10", 2);
                AddCardToDeck(Suit.SuitType.Spade, "J", 3);
                AddCardToDeck(Suit.SuitType.Spade, "J", 3);
                AddCardToDeck(Suit.SuitType.Spade, "Q", 4);
                AddCardToDeck(Suit.SuitType.Spade, "Q", 4);
                AddCardToDeck(Suit.SuitType.Spade, "K", 5);
                AddCardToDeck(Suit.SuitType.Spade, "K", 5);
                AddCardToDeck(Suit.SuitType.Spade, "A", 6);
                AddCardToDeck(Suit.SuitType.Spade, "A", 6);
            }
        }

        public List<Hand> Deal()
        {
            var hands = base.Deal(4, 12);
            return hands;
        }

    }
}
