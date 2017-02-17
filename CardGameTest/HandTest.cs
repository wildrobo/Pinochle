using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame;
using NUnit.Framework;
//TODO: Update all instances to use this and remove all SuitType's
using static CardGame.Suit.SuitType;


namespace CardGameTest
{
    

    [TestFixture]
    class HandTest
    {

        [Test]
        public void CardContains()
        {
            var hand = new Hand();
            var Cards = new List<ICard>();
            Cards.Add(new Card("A", Heart, 13));
            Cards.Add(new Card("K", Heart, 12));
            Cards.Add(new Card("A", Spade, 13));
            Cards.Add(new Card("K", Spade, 12));
            Cards.Add(new Card("Q", Spade, 11));
            Cards.Add(new Card("J", Spade, 10));


            var CardsToCompare = new List<ICard>();
            CardsToCompare.Add(new Card("K", Spade, 12));
            CardsToCompare.Add(new Card("Q", Spade, 11));

            hand.Cards = Cards;
            Assert.IsTrue(hand.Contains(CardsToCompare));

        }
    }
}
