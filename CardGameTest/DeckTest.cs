using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame;
using NUnit.Framework;

namespace CardGameTest
{
    

    [TestFixture]
    class DeckTest
    {
        [Test]
        public void ShuffleDeckWithNoCards()
        {
            Deck deck = new Deck();
            Assert.Throws(typeof(System.Exception), new TestDelegate(deck.Shuffle));
        }
    }
}
