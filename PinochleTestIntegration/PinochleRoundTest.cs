using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame;
using Pinochle;
using NUnit.Framework;

namespace PinochleTest
{
    class PinochleRoundTest
    {
        [Test]
        public void TestRound()
        {
            //TODO: use Mocks for players and Game
            Player One = new Player("North");
            Player Two = new Player("East");
            Player Three = new Player("South");
            Player Four = new Player("West");
            PinochleGame Game = new PinochleGame(One, Two, Three, Four);

            PinochleRound round = new PinochleRound(Game.GetNextDealer());
            PinochleDeck deck = new PinochleDeck();
            deck.Shuffle();
            List<Hand> hands = deck.Deal();
            round.HandPlayerOne = hands[0];
            round.HandPlayerTwo = hands[1];
            round.HandPlayerThree = hands[2];
            round.HandPlayerFour = hands[3];
            //bid
            //select suit
            //pass
            //pass back
            //meld
            //play
            //score
            Assert.Fail();
        }
    }
}
