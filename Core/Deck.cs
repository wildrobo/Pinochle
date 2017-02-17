using System;
using System.Collections.Generic;



namespace CardGame
{
    public class Deck
    { 
        public List<Card> Cards { get; set; }

        public Deck()
        {
            Cards = new List<Card>();
        }

        public void Shuffle()
        {
            if (Cards.Count == 0){
                throw new Exception("No cards are in the deck. The deck is not initalized.");
            }
            var rnd = new Random();
            var ShuffledDeck = new List<Card>();

            while (Cards.Count > 0)
            {
                var randomNumber = rnd.Next(0, Cards.Count -1);

                var card = Cards[randomNumber];
                ShuffledDeck.Add(card);
                Cards.RemoveAt(randomNumber);
            }
            Cards = ShuffledDeck;
        }

        protected void AddCardToDeck(Suit.SuitType suit, string value, int rank)
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