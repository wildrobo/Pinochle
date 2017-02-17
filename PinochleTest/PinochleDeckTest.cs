using System;
using Pinochle;
using NUnit.Framework;

namespace PinochleTest
{
    [TestFixture]
    public class PinochleDeckTest
    {
        [Test]
        public void ShufflePinochle()
        {
            PinochleDeck deck = new PinochleDeck();
            deck.Shuffle();
            Assert.AreEqual(deck.Cards.Count, 48);
        }

        [Test]
        public void Deal()
        {
            //TODO: Create Deck with known values
            //Is this Integration Test?
            PinochleDeck deck = new PinochleDeck();
            var hands = deck.Deal(4, 12);
            Assert.AreEqual(hands[0].Cards.Count, 12);
            Assert.AreEqual(hands[1].Cards.Count, 12);
            Assert.AreEqual(hands[2].Cards.Count, 12);
            Assert.AreEqual(hands[3].Cards.Count, 12);

        }
    }
}
