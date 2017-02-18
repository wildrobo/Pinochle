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
        //private List<MeldType> AllMeldTypes = new List<MeldType>();
        Suit.SuitType Trump { get; set; }
        //public int Family { get; set; }


        //public int MarriageInTrump { get; set; }

        //public int NineOfTrump { get; set; }
        //public int AcesRound { get; set; }
        //public int KingsRound { get; set; }
        //public int QueensRound { get; set; }
        //public int JacksRound { get; set; }
        //public int Pinochle { get; set; }
        //public int DoubleFamily { get; set; }
        //public int DoubleMarriageInTrump { get; set; }
        //public int DoubleMarriage { get; set; }
        //public int DoubleNineOfTrump { get; set; }
        //public int DoubleAcesRound { get; set; }
        //public int DoubleKingsRound { get; set; }
        //public int DoubleQueensRound { get; set; }
        //public int DoubleJacksRound { get; set; }
        //public int DoublePinochle { get; set; }
        //public int MarriagesRound { get; set; }

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
            //Family = 15;
            //MarriageInTrump = 4;
            //Marriage = 2;
            //NineOfTrump = 1;
            //AcesRound = 10;
            //KingsRound = 8;
            //QueensRound = 6;
            //JacksRound = 4;
            //Pinochle = 4;
            //DoubleFamily = 150; ;
            //DoubleMarriageInTrump = 8;
            //DoubleMarriage = 4;
            //DoubleNineOfTrump = 2;
            //DoubleAcesRound = 150;
            //DoubleKingsRound = 80;
            //DoubleQueensRound = 60;
            //DoubleJacksRound = 40;
            //DoublePinochle = 30;
            //MarriagesRound = 24;
        }

        private List<MeldType> GetAllMeldTypes(IPinochleHand hand)
        {
            var allMeldTypes = new List<MeldType>();
            //TODO: figure out how to do this only once per hand...bool isInitialized or something like 
            //TODO: replace magic number for value with Constant  Card.ACE_VALUE = 6

            MeldType family = new MeldType("Family", 15, 1, new List<ICard>() {
                  new Card("A", Trump, 6)
                , new Card("10", Trump, 5)
                , new Card("K", Trump, 4)
                , new Card("Q", Trump, 3)
                , new Card("J", Trump, 2)

            });
            allMeldTypes.Add(family);

            if (!allMeldTypes.Contains(family))
            {
                MeldType marriageInTrump = new MeldType("Marriage In Trump", 4, 1, new List<ICard>() {
                      new Card("K", Trump, 4)
                    , new Card("Q", Trump, 3)
                });
                allMeldTypes.Add(marriageInTrump);
            }

            MeldType doubleMarriageInTrump = new MeldType("Second Marraige In Trump", 4, 2, new List<ICard>() {
                      new Card("K", Trump, 4)
                    , new Card("Q", Trump, 3)
                    , new Card("K", Trump, 4)
                    , new Card("Q", Trump, 3)
                });
            allMeldTypes.Add(doubleMarriageInTrump);

            MeldType acesRound = new MeldType("Aces Round", 10, 2, new List<ICard>() {
                      new Card("A", Club, 6)
                    , new Card("A", Diamond, 6)
                    , new Card("A", Heart, 6)
                    , new Card("A", Spade, 6)
                });
            allMeldTypes.Add(doubleMarriageInTrump);

            MeldType MarriageInHearts = new MeldType("Marriage In Hearts", 2, 1, new List<ICard>() { new Card("K", Heart, 4), new Card("Q", Heart, 3) });

            return allMeldTypes;
        }

        public List<MeldType> Calculate(IPinochleHand hand)
        {
            var result = new List<MeldType>();
            List<ICard> cards = hand.Cards;

            if (hand.Trump == None)
            {
                throw new Exception("Trump must be set before you can calculate the meld value.");
            }


            var allMeldTypes = GetAllMeldTypes(hand);

            foreach (var meldType in allMeldTypes)
            {
                if (hand.Contains(meldType.Cards))
                {
                    result.Add(meldType);
                }
            }

            return result;

        }
    }
}