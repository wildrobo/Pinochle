using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CardGame;

namespace CardGameTest
{
    [TestFixture]
    class CardTest
    {
        [Test]
        public void CardEquals()
        {
            ICard Card1 = new Card("J", Suit.SuitType.Diamond, 2);
            ICard Card2 = new Card("J", Suit.SuitType.Diamond, 2);
            Assert.AreEqual(Card1, Card2);
        }

        [Test]
        public void CardNotEquals()
        {
            //Value not equal
            ICard Card1 = new Card("9", Suit.SuitType.Diamond, 2);
            ICard Card2 = new Card("J", Suit.SuitType.Diamond, 2);
            Assert.AreNotEqual(Card1, Card2);

            //Suit not equal
            ICard Card3 = new Card("J", Suit.SuitType.Club, 2);
            ICard Card4 = new Card("J", Suit.SuitType.Diamond, 2);
            Assert.AreNotEqual(Card1, Card2);

            //rank not equal
            ICard Card5 = new Card("J", Suit.SuitType.Diamond, 1);
            ICard Card6 = new Card("J", Suit.SuitType.Diamond, 2);
            Assert.AreNotEqual(Card1, Card2);

        }
    }
}
