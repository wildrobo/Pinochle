using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pinochle;
using Moq;
using CardGame;
using static CardGame.Suit.SuitType;

namespace PinochleTestHelper
{
    public class PinochleHandTestHelper
    {
        //public IPinochleHand GetPinochleHand()
        //{
        //    PinochleCardTestHelper cardHelper = new PinochleCardTestHelper();
        //    Mock<IHand> hand = new Mock<IHand>();

        //    List<ICard> cards = new List<ICard>
        //    {
        //        cardHelper.GetMockCard("A",Suit.SuitType.Diamond,6)
        //        ,cardHelper.GetMockCard("A",Suit.SuitType.Diamond,6)
        //        ,cardHelper.GetMockCard("10",Suit.SuitType.Diamond,5)
        //        ,cardHelper.GetMockCard("K",Suit.SuitType.Diamond,4)
        //        ,cardHelper.GetMockCard("Q",Suit.SuitType.Diamond,3)
        //        ,cardHelper.GetMockCard("J",Suit.SuitType.Diamond,2)
        //        ,cardHelper.GetMockCard("9",Suit.SuitType.Diamond,1)
        //        ,cardHelper.GetMockCard("9",Suit.SuitType.Diamond,1)
        //        ,cardHelper.GetMockCard("A",Suit.SuitType.Heart,6)
        //        ,cardHelper.GetMockCard("A",Suit.SuitType.Spade,6)
        //        ,cardHelper.GetMockCard("A",Suit.SuitType.Club,6)
        //        ,cardHelper.GetMockCard("Q",Suit.SuitType.Spade,3)
        //        ,cardHelper.GetMockCard("Q",Suit.SuitType.Spade,3)
        //    };

        //    Mock<IPinochleHand> pinochleHand = new Mock<IPinochleHand>();
        //    pinochleHand.SetupProperty(x => x.Cards, cards);

        //    return pinochleHand.Object;
        //}
        public IPinochleHand GetTestHand()
        {
            IPinochleHand hand = new PinochleHand();
            PinochleCardTestHelper cardHelper = new PinochleCardTestHelper();
            hand.Cards = cardHelper.GetTestCards();
            hand.Trump = Diamond;
            return hand;
        }

        public List<ICard> GetSortTestCards()
        {
            PinochleCardTestHelper cardHelper = new PinochleCardTestHelper();
            List<ICard> cards = new List<ICard>
            {
                cardHelper.GetMockCard("A",Suit.SuitType.Diamond,6)
                ,cardHelper.GetMockCard("9",Suit.SuitType.Diamond,1)
                ,cardHelper.GetMockCard("Q",Suit.SuitType.Diamond,3)
                ,cardHelper.GetMockCard("A",Suit.SuitType.Club,6)
                ,cardHelper.GetMockCard("Q",Suit.SuitType.Spade,3)
                ,cardHelper.GetMockCard("10",Suit.SuitType.Diamond,5)
                ,cardHelper.GetMockCard("K",Suit.SuitType.Diamond,4)
                ,cardHelper.GetMockCard("9",Suit.SuitType.Heart,1)
                ,cardHelper.GetMockCard("J",Suit.SuitType.Diamond,2)
                 ,cardHelper.GetMockCard("A",Suit.SuitType.Spade,6)
                ,cardHelper.GetMockCard("9",Suit.SuitType.Diamond,1)
                ,cardHelper.GetMockCard("A",Suit.SuitType.Heart,6)
                ,cardHelper.GetMockCard("A",Suit.SuitType.Club,6)
                ,cardHelper.GetMockCard("Q",Suit.SuitType.Spade,3)
            };
            return cards;
        }

        ////not sure if need this
        //public ICard GetMockCard(string value, Suit.SuitType suit, int rank)
        //{
        //    Mock<ICard> card = new Mock<ICard>();
        //    card.SetupAllProperties();
        //    card.Object.Value = value;
        //    card.Object.Suit = suit;
        //    card.Object.Rank = rank;
        //    return card.Object;
        //}

        //public List<ICard> GetTestCards()
        //{
        //    CardTestHelper cardHelper = new CardTestHelper();
        //    List<ICard> cards = new List<ICard>
        //    {
        //        cardHelper.GetMockCard("A",Suit.SuitType.Diamond,6)
        //        ,cardHelper.GetMockCard("A",Suit.SuitType.Diamond,6)
        //        ,cardHelper.GetMockCard("10",Suit.SuitType.Diamond,5)
        //        ,cardHelper.GetMockCard("K",Suit.SuitType.Diamond,4)
        //        ,cardHelper.GetMockCard("Q",Suit.SuitType.Diamond,3)
        //        ,cardHelper.GetMockCard("J",Suit.SuitType.Diamond,2)
        //        ,cardHelper.GetMockCard("9",Suit.SuitType.Diamond,1)
        //        ,cardHelper.GetMockCard("9",Suit.SuitType.Diamond,1)
        //        ,cardHelper.GetMockCard("A",Suit.SuitType.Heart,6)
        //        ,cardHelper.GetMockCard("A",Suit.SuitType.Spade,6)
        //        ,cardHelper.GetMockCard("A",Suit.SuitType.Club,6)
        //        ,cardHelper.GetMockCard("Q",Suit.SuitType.Spade,3)
        //        ,cardHelper.GetMockCard("Q",Suit.SuitType.Spade,3)
        //    };
        //    return cards;
        //}


    }
}
