using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using CardGame;
using CardGameTestHelper;
using Pinochle;

namespace PinochleTestHelper 
{
    public class PinochleCardTestHelper : CardTestHelper
    {
        public IPinochleCard GetMockCard(string value, Suit.SuitType suit, int rank, bool isTrump = false)
        {
            IPinochleCard card = (IPinochleCard)base.GetMockCard(value, suit, rank);
            card.IsTrump = isTrump;
            return card;
        }

        //public new List<ICard> GetTestMockCards()
        //{

        //    List<ICard> cards = new List<ICard>
        //    {
        //        GetMockCard("A",Suit.SuitType.Diamond,6,true)
        //        ,GetMockCard("A",Suit.SuitType.Diamond,6,true)
        //        ,GetMockCard("10",Suit.SuitType.Diamond,5,true)
        //        ,GetMockCard("K",Suit.SuitType.Diamond,4,true)
        //        ,GetMockCard("Q",Suit.SuitType.Diamond,3,true)
        //        ,GetMockCard("J",Suit.SuitType.Diamond,2,true)
        //        ,GetMockCard("9",Suit.SuitType.Diamond,1,true)
        //        ,GetMockCard("9",Suit.SuitType.Diamond,1,true)
        //        ,GetMockCard("A",Suit.SuitType.Heart,6)
        //        ,GetMockCard("A",Suit.SuitType.Spade,6)
        //        ,GetMockCard("A",Suit.SuitType.Club,6)
        //        ,GetMockCard("Q",Suit.SuitType.Spade,3)
        //        ,GetMockCard("Q",Suit.SuitType.Spade,3)
        //    };
        //    return cards;
        //}

        public new List<ICard> GetTestCards()
        {
            List<ICard> cards = new List<ICard>
            {
                new Card("A",Suit.SuitType.Diamond,6)
                ,new Card("A",Suit.SuitType.Diamond,6)
                ,new Card("10",Suit.SuitType.Diamond,5)
                ,new Card("K",Suit.SuitType.Diamond,4)
                ,new Card("Q",Suit.SuitType.Diamond,3)
                ,new Card("J",Suit.SuitType.Diamond,2)
                ,new Card("9",Suit.SuitType.Diamond,1)
                ,new Card("9",Suit.SuitType.Diamond,1)
                ,new Card("A",Suit.SuitType.Heart,6)
                ,new Card("A",Suit.SuitType.Spade,6)
                ,new Card("A",Suit.SuitType.Club,6)
                ,new Card("Q",Suit.SuitType.Spade,3)
                ,new Card("Q",Suit.SuitType.Spade,3)
            };
            return cards;
        }

        public static implicit operator PinochleCardTestHelper(PinochleHandTestHelper v)
        {
            throw new NotImplementedException();
        }
    }
}
