using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Pinochle;
using PinochleTestHelper;
using Moq;
using static CardGame.Suit;
using CardGame;


namespace PinochleTest
{
    [TestFixture]
    class MeldTest
    {
        PinochleHandTestHelper _handHelper;

        [SetUp]
        public void Setup()
        {
            _handHelper = new PinochleHandTestHelper();
        }

        [Test]
        public void TestMeld()
        {

            var hand = _handHelper.GetPinochleHand();
            hand.GetMeld();
            


        }
    }
}
