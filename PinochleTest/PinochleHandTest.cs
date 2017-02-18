using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Pinochle;
using PinochleTestHelper;
using static CardGame.Suit;
using static CardGame.Suit.SuitType;
using Moq;

namespace PinochleTest
{
    [TestFixture]
    class PinochleHandTest
    {
        PinochleHandTestHelper _handHelper;

        [SetUp]
        public void Setup()
        {
            _handHelper = new PinochleHandTestHelper();
        }

        [Test]
        public void GetMaxBid()
        {
            var hand = _handHelper.GetTestCards();

            Assert.Fail();
        }

        [Test]
        public void SelectSuit()
        {
            Assert.Fail();
        }

        [Test]
        public void PassToBidder()
        {
            Assert.Fail();
        }

        [Test]
        public void PassToNonBidder()
        {
            Assert.Fail();
        }

        [Test]
        public void GetMeldForHand()
        {
            IPinochleHand hand = new PinochleHand();
            hand.Trump = Diamond;
            hand.Cards = _handHelper.GetTestCards();
            int maxBid = hand.GetMeld();

            Assert.Fail();
        }

        [Test]
        public void PlayCard()
        {
            Assert.Fail();
        }

        [Test]
        public void Sort()
        {
            IPinochleHand hand = new PinochleHand();
            hand.Cards = _handHelper.GetSortTestCards();
            hand.Sort();

            Assert.Fail();
        }
    }


}
