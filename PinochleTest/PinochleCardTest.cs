using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Pinochle;


using Moq;
using static CardGame.Suit;

namespace PinochleTest
{
    [TestFixture]
    class PinochleCardTest
    {

        [SetUp]
        public void Setup()
        {
          
        }


        [Test]
        public void CardCompare()
        {

            //Value not equal
            PinochleCard Card1 = new PinochleCard("9", SuitType.Diamond, 1);
            PinochleCard Card2 = new PinochleCard("J", SuitType.Diamond, 2);
            PinochleCard Card3 = new PinochleCard("9", SuitType.Club, 1);
            PinochleCard Card4 = new PinochleCard("J", SuitType.Club, 2);
            PinochleCard TrumpCard1 = new PinochleCard("9", SuitType.Heart, 1, true);
            PinochleCard TrumpCard2 = new PinochleCard("J", SuitType.Heart, 2, true);

            //same suit
            Assert.IsTrue(Card1 < Card2);
            Assert.IsFalse(Card2 < Card1);
            Assert.IsTrue(Card2 > Card1);
            Assert.IsFalse(Card1 > Card2);

            //different suit
            Assert.IsTrue(Card1 < Card4);
            Assert.IsFalse(Card4 < Card1);
            Assert.IsTrue(Card4 > Card1);
            Assert.IsFalse(Card1 > Card4);

            //trump
            Assert.IsTrue(TrumpCard1 < TrumpCard2);
            Assert.IsFalse(TrumpCard2 < TrumpCard1);
            Assert.IsTrue(TrumpCard2 > TrumpCard1);
            Assert.IsFalse(TrumpCard1 > TrumpCard2);

            //mixed with trump
            Assert.IsTrue(Card2 < TrumpCard1);
            Assert.IsFalse(TrumpCard1 < Card2);
            Assert.IsTrue(TrumpCard1 > Card2);
            Assert.IsFalse(Card2 > TrumpCard1);
        }


    }
}

