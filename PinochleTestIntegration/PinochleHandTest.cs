using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame;
using Pinochle;
using NUnit.Framework;
using static CardGame.Suit.SuitType;
using PinochleTestHelper;

namespace PinochleTestIntegration
{
    class PinochleHandTest
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
            IPinochleHand hand = _handHelper.GetTestHand();
            int meldValue = hand.GetMeld();
            foreach (var meldType in hand.Meld.Types)
            {
                Console.WriteLine(meldType.Value + " - " + meldType.Name);
            }
            Console.WriteLine("Meld Total: " + hand.Meld.MeldValue);
            Assert.AreEqual(meldValue, 31);
        }
    }
}
