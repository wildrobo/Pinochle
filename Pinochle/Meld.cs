using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame;
using static CardGame.Suit.SuitType;

namespace Pinochle
{
    public class Meld
    {
        public int Family { get; set; }
        public int MarriageInTrump { get; set; }
        public int Marriage { get; set; }
        public int NineOfTrump { get; set; }
        public int AcesRound { get; set; }
        public int KingsRound { get; set; }
        public int QueensRound { get; set; }
        public int JacksRound { get; set; }
        public int Pinochle { get; set; }
        public int DoubleFamily { get; set; }
        public int DoubleMarriageInTrump { get; set; }
        public int DoubleMarriage { get; set; }
        public int DoubleNineOfTrump { get; set; }
        public int DoubleAcesRound { get; set; }
        public int DoubleKingsRound { get; set; }
        public int DoubleQueensRound { get; set; }
        public int DoubleJacksRound { get; set; }
        public int DoublePinochle { get; set; }
        public int MarriagesRound { get; set; }

        //public Meld()
        //{
        //    Suit = CardGame.Suit.SuitType.None;
        //    Family = 15;
        //    MarriageInTrump = 4;
        //    Marriage = 2;
        //    NineOfTrump = 1;
        //    AcesRound = 10;
        //    KingsRound = 8;
        //    QueensRound = 6;
        //    JacksRound = 4;
        //    Pinochle = 4;
        //    DoubleFamily = 150; ;
        //    DoubleMarriageInTrump = 8;
        //    DoubleMarriage = 4;
        //    DoubleNineOfTrump = 2;
        //    DoubleAcesRound = 150;
        //    DoubleKingsRound = 80;
        //    DoubleQueensRound = 60;
        //    DoubleJacksRound = 40;
        //    DoublePinochle = 30;
        //    MarriagesRound = 24;
        //}

        public Meld()
        {
            Family = 15;
            MarriageInTrump = 4;
            Marriage = 2;
            NineOfTrump = 1;
            AcesRound = 10;
            KingsRound = 8;
            QueensRound = 6;
            JacksRound = 4;
            Pinochle = 4;
            DoubleFamily = 150; ;
            DoubleMarriageInTrump = 8;
            DoubleMarriage = 4;
            DoubleNineOfTrump = 2;
            DoubleAcesRound = 150;
            DoubleKingsRound = 80;
            DoubleQueensRound = 60;
            DoubleJacksRound = 40;
            DoublePinochle = 30;
            MarriagesRound = 24;
        }

        public int Calculate(IPinochleHand hand)
        {
            int totalMeld = 0;
            List<ICard> cards = hand.Cards;

            if (hand.Trump == None)
            {
                throw new Exception("Trump must be set before you can calculate the meld value.");
            }

            //define cards for meld type
            //test contains

            return totalMeld;

        }
    }
}
