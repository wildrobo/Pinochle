using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame;

namespace Pinochle
{
    public class PinochleTrick
    {
        public Card PlayerOne { get; set; }
        public Card PlayerTwoCard { get; set; }
        public Card PlayerThreeCard { get; set; }
        public Card PlayerFourCard { get; set; }
        public Suit.SuitType SuitLed { get; set; }
        public Player Lead { get; set; }
        public Player Winner { get; set; }
        public int TrickNumber { get; set; }
        public int NumberOfPoints {
            get {
                return CalculatePointsForHand();
            }
        }
     
        public int CalculatePointsForHand()
        {
            return 0;

        }
    }
}
