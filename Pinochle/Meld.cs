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
        public int MeldValue { get; set; }
        public List<MeldType> Types { get; set; }
        public MeldType Family { get; set; }
        public MeldType DoubleFamily { get; set; }
        public MeldType MarriageInTrump { get; set; }
        public MeldType DoubleMarriageInTrump { get; set; }
        public MeldType MarriageInClubs { get; set; }
        public MeldType MarriageInDiamonds { get; set; }
        public MeldType MarriageInHearts { get; set; }
        public MeldType MarriageInSpades { get; set; }
        public MeldType DoubleMarriageInClubs { get; set; }
        public MeldType DoubleMarriageInDiamonds { get; set; }
        public MeldType DoubleMarriageInHearts { get; set; }
        public MeldType DoubleMarriageInSpades { get; set; }
        public MeldType NineOfTrump { get; set; }
        public MeldType AcesRound { get; set; }
        public MeldType DoubleAcesRound { get; set; }
        public MeldType KingsRound { get; set; }
        public MeldType DoubleKingsRound { get; set; }
        public MeldType QueensRound { get; set; }
        public MeldType DoubleQueensRound { get; set; }
        public MeldType JacksRound { get; set; }
        public MeldType DoubleJacksRound { get; set; }
        public MeldType Pinochle { get; set; }
        public MeldType DoublePinochle { get; set; }


        public Meld()
        {

        }

        //values for all meld found here
        private List<MeldType> GetAllMeldTypes()
        {
            var allMeldTypes = new List<MeldType>();
            //TODO: figure out how to do this only once per hand...bool isInitialized or something like 
            //TODO: replace magic number for value with Constant  Card.ACE_VALUE = 6

            Family = new MeldType("Family", 15, 1, new List<ICard>() {
                  new Card("A", Trump, 6)
                , new Card("10", Trump, 5)
                , new Card("K", Trump, 4)
                , new Card("Q", Trump, 3)
                , new Card("J", Trump, 2)

            });
            allMeldTypes.Add(Family);

            DoubleFamily = new MeldType("Double Family", 150, 2, new List<ICard>() {
                  new Card("A", Trump, 6)
                , new Card("10", Trump, 5)
                , new Card("K", Trump, 4)
                , new Card("Q", Trump, 3)
                , new Card("J", Trump, 2)
                 , new Card("A", Trump, 6)
                , new Card("10", Trump, 5)
                , new Card("K", Trump, 4)
                , new Card("Q", Trump, 3)
                , new Card("J", Trump, 2)

            });
            allMeldTypes.Add(DoubleFamily);

            MarriageInTrump = new MeldType("Marriage In Trump", 4, 2, new List<ICard>() {
                      new Card("K", Trump, 4)
                    , new Card("Q", Trump, 3)
                });
            allMeldTypes.Add(MarriageInTrump);

            DoubleMarriageInTrump = new MeldType("Second Marraige In Trump", 4, 3, new List<ICard>() {
                      new Card("K", Trump, 4)
                    , new Card("Q", Trump, 3)
                    , new Card("K", Trump, 4)
                    , new Card("Q", Trump, 3)
                });
            allMeldTypes.Add(DoubleMarriageInTrump);

            //TODO: Think I can clean this up...a lot of cutting and pasting...bad
            MarriageInClubs = new MeldType("Marriage In Clubs", 2, 1, new List<ICard>() { new Card("K", Club, 4), new Card("Q", Club, 3) });
            if (Trump != Club)
            {
                allMeldTypes.Add(MarriageInClubs);
            }
            MarriageInDiamonds = new MeldType("Marriage In Diamonds", 2, 1, new List<ICard>() { new Card("K", Diamond, 4), new Card("Q", Diamond, 3) });
            if (Trump != Diamond)
            {
                allMeldTypes.Add(MarriageInDiamonds);
            }
            MarriageInHearts = new MeldType("Marriage In Hearts", 2, 1, new List<ICard>() { new Card("K", Heart, 4), new Card("Q", Heart, 3) });
            if (Trump != Heart)
            {
                allMeldTypes.Add(MarriageInHearts);
            }
            MarriageInSpades = new MeldType("Marriage In Spades", 2, 1, new List<ICard>() { new Card("K", Spade, 4), new Card("Q", Spade, 3) });
            if (Trump != Spade)
            {
                allMeldTypes.Add(MarriageInSpades);
            }

            DoubleMarriageInClubs = new MeldType("Second Marriage In Clubs", 2, 3, new List<ICard>() {
                new Card("K", Club, 4)
                , new Card("Q", Club, 3)
                , new Card("K", Club, 4)
                , new Card("Q", Club, 3) });
            if (Trump != Club)
            {
                allMeldTypes.Add(DoubleMarriageInClubs);
            }
            DoubleMarriageInDiamonds = new MeldType("Second Marriage In Diamonds", 2, 3, new List<ICard>() {
                new Card("K", Diamond, 4)
                , new Card("Q", Diamond, 3)
                ,new Card("K", Diamond, 4)
                , new Card("Q", Diamond, 3)
            });
            if (Trump != Diamond)
            {
                allMeldTypes.Add(DoubleMarriageInDiamonds);
            }
            DoubleMarriageInHearts = new MeldType("Second Marriage In Hearts", 2, 3, new List<ICard>() {
                new Card("K", Heart, 4)
                , new Card("Q", Heart, 3)
                , new Card("K", Heart, 4)
                , new Card("Q", Heart, 3)
            });
            if (Trump != Heart)
            {
                allMeldTypes.Add(DoubleMarriageInHearts);
            }
            DoubleMarriageInSpades = new MeldType("Second Marriage In Spades", 2, 3, new List<ICard>() {
                new Card("K", Spade, 4)
                , new Card("Q", Spade, 3)
                ,new Card("K", Spade, 4)
                , new Card("Q", Spade, 3)
            });
            if (Trump != Spade)
            {
                allMeldTypes.Add(DoubleMarriageInSpades);
            }

            NineOfTrump = new MeldType("Nine if Trump", 2, 1, new List<ICard>() { new Card("9", Trump, 1) });
            allMeldTypes.Add(NineOfTrump);

            AcesRound = new MeldType("Aces Round", 10, 2, new List<ICard>() {
                      new Card("A", Club, 6)
                    , new Card("A", Diamond, 6)
                    , new Card("A", Heart, 6)
                    , new Card("A", Spade, 6)
                });
            allMeldTypes.Add(AcesRound);

            DoubleAcesRound = new MeldType("Double Aces Round", 100, 3, new List<ICard>() {
                      new Card("A", Club, 6)
                    , new Card("A", Diamond, 6)
                    , new Card("A", Heart, 6)
                    , new Card("A", Spade, 6)
                    , new Card("A", Club, 6)
                    , new Card("A", Diamond, 6)
                    , new Card("A", Heart, 6)
                    , new Card("A", Spade, 6)
                });
            allMeldTypes.Add(DoubleAcesRound);

            KingsRound = new MeldType("Kings Round", 8, 2, new List<ICard>() {
                      new Card("K", Club, 4)
                    , new Card("K", Diamond, 4)
                    , new Card("K", Heart, 4)
                    , new Card("K", Spade, 4)
                });
            allMeldTypes.Add(KingsRound);

            MeldType DoubleKingsRound = new MeldType("Double Kings Round", 80, 3, new List<ICard>() {
                      new Card("K", Club, 4)
                    , new Card("K", Diamond, 4)
                    , new Card("K", Heart, 4)
                    , new Card("K", Spade, 4)
                    , new Card("K", Club, 4)
                    , new Card("K", Diamond, 4)
                    , new Card("K", Heart, 4)
                    , new Card("K", Spade, 4)
                });
            allMeldTypes.Add(DoubleKingsRound);

            QueensRound = new MeldType("Queens Round", 6, 2, new List<ICard>() {
                      new Card("Q", Club, 3)
                    , new Card("Q", Diamond, 3)
                    , new Card("Q", Heart, 3)
                    , new Card("Q", Spade, 3)
                });
            allMeldTypes.Add(QueensRound);

            DoubleQueensRound = new MeldType("Double Queens Round", 60, 3, new List<ICard>() {
                      new Card("Q", Club, 3)
                    , new Card("Q", Diamond, 3)
                    , new Card("Q", Heart, 3)
                    , new Card("Q", Spade, 3)
                    , new Card("Q", Club, 3)
                    , new Card("Q", Diamond, 3)
                    , new Card("Q", Heart, 3)
                    , new Card("Q", Spade, 3)
                });
            allMeldTypes.Add(DoubleQueensRound);

            JacksRound = new MeldType("Jacks Round", 4, 2, new List<ICard>() {
                      new Card("J", Club, 2)
                    , new Card("J", Diamond, 2)
                    , new Card("J", Heart, 2)
                    , new Card("J", Spade, 2)
                });
            allMeldTypes.Add(JacksRound);

            DoubleJacksRound = new MeldType("Double Jacks Round", 40, 2, new List<ICard>() {
                  new Card("J", Club, 2)
                , new Card("J", Diamond, 2)
                , new Card("J", Heart, 2)
                , new Card("J", Spade, 2)
                , new Card("J", Club, 2)
                , new Card("J", Diamond, 2)
                , new Card("J", Heart, 2)
                , new Card("J", Spade, 2)
            });
            allMeldTypes.Add(DoubleJacksRound);

            Pinochle = new MeldType("Pinochle", 4, 1, new List<ICard>() {
                new Card("J", Diamond, 2)
                , new Card("Q", Spade, 3)
            });
            allMeldTypes.Add(Pinochle);

            DoublePinochle = new MeldType("Double Pinochle", 30, 2, new List<ICard>() {
                new Card("J", Diamond, 2)
                , new Card("Q", Spade, 3)
                , new Card("J", Diamond, 2)
                , new Card("Q", Spade, 3)
            });
            allMeldTypes.Add(DoublePinochle);

            //TODO: Think about implementing, would wipe out Marriage in Trump, all other marriages, Ks round and Qs round
            //MarriagesRound = 24;

            return allMeldTypes;
        }

        public List<MeldType> Calculate(IPinochleHand hand)
        {
            Types = new List<MeldType>();
            int meldValue = 0;
            List<ICard> cards = hand.Cards;
            Trump = hand.Trump;

            if (Trump == None)
            {
                throw new Exception("Trump must be set before you can calculate the meld value.");
            }


            var allMeldTypes = GetAllMeldTypes();

            foreach (var meldType in allMeldTypes)
            {
                var addMeldType = true;
                if (hand.Contains(meldType.Cards))
                {
                    if (meldType == MarriageInTrump)
                    {
                        if (Types.Contains(Family))
                        {
                            //do not add
                            addMeldType = false;
                        }
                    }
                    if (Types.Contains(DoubleMarriageInTrump))
                    {
                        //do not add
                        //replace with meld type additional marriage in trump
                        if (Types.Contains(Family))
                        {
                            //do not add
                            DoubleMarriageInTrump.Value = 4;
                            addMeldType = false;
                            Types.Add(DoubleMarriageInTrump);
                            meldValue += meldType.Value;
                        }

                    }
                    if (addMeldType == true)
                    {
                        Types.Add(meldType);
                        meldValue += meldType.Value;
                    }
                    
                }
            }

            MeldValue = meldValue;
            return Types;

        }
    }
}