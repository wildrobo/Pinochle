using System;
using System.Collections.Generic;



namespace Core
{
    public class Deck : IDeck
    { 
        public enum DeckType
        {
            Regular = 1,
            SingleDeckPinochle = 2
        };

        public List<Card> Cards { get; set; }
        private DeckType _deckType;

        public Deck(DeckType deckType = DeckType.Regular)
        {
            _deckType = deckType;
        }

        public void Shuffle()
        {
            var rnd = new Random();
            var ShuffledDeck = new List<Card>();

            Initialize();

            while (Cards.Count > 0)
            {
                var randomNumber = rnd.Next(0, Cards.Count -1);

                var card = Cards[randomNumber];
                ShuffledDeck.Add(card);
                Cards.RemoveAt(randomNumber);
            }
            Cards = ShuffledDeck;
        }
       
        private void Initialize()
        {
            if (Cards == null || Cards.Count == 0)
            {
                switch (_deckType)
                {
                    case DeckType.SingleDeckPinochle:
                        InitializeSingleDeckPinochle();
                        break;
                    default:
                        throw new Exception(String.Format("Deck type: {0} not implemented", Enum.GetName(typeof(DeckType), _deckType)));
                }
            }
        }
        private void InitializeSingleDeckPinochle()
        {
            Cards = new List<Card>();
            
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

        private void AddCardToDeck(Suit.SuitType suit, string value, int rank)
        {
            Card newCard = new Card(value, suit, rank);
            Cards.Add(newCard);
        }


        public List<Hand> Deal(int numberOfHands, int numberOfCardsPerHand)
        {
            var hands = new List<Hand>();
            var rnd = new Random();

            for (int x = 0; x < numberOfHands; x++)
            {
                var newHand = new Hand();
                hands.Add(newHand);
            }

            for (int x = 0; x < numberOfCardsPerHand; x++)
            {
                for (int y = 0; y < numberOfHands; y++)
                { 
                    var randomNumber = rnd.Next(0, Cards.Count - 1);
                    var card = Cards[randomNumber];
                    hands[y].Cards.Add(card);
                    Cards.RemoveAt(randomNumber);
                }
            }
            return hands;
        }
    }
}