using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame;

namespace Pinochle
{
    public class PinochleRound
    {
        public List<PinochleTrick> Tricks { get; set; }
        public Deck Deck { get; set; }
        public Player Dealer { get; set; }

        public Hand HandPlayerOne { get; set; }
        public Hand HandPlayerTwo { get; set; }
        public Hand HandPlayerThree { get; set; }
        public Hand HandPlayerFour { get; set; }
        public PinochleRound(Player dealer)
        {
            Dealer = dealer;
        }
        public Player PlayTrick(Card playerOne, Card playerTwo, Card playerThree, Card playerFour)
        {
            Player winner = new Player("North");
            PinochleTrick newTrick = new PinochleTrick();


            return winner;
        }
    }
}
