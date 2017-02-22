using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using CardGame;
using static CardGame.Suit;
using static CardGame.Suit.SuitType;

namespace CardGameTestHelper
{
    public class CardTestHelper
    {

        public ICard GetMockCard(string value, SuitType suit, int rank)
        {
            Mock<ICard> card = new Mock<ICard>();
            card.SetupAllProperties();
            card.Object.Value = value;
            card.Object.Suit = suit;
            card.Object.Rank = rank;
            string key = value + Enum.GetName(typeof(SuitType), suit) + rank.ToString();
            //card.Setup(m => m.ToString()).Returns(key);
            card.Setup(m => m.ToString()).CallBase();
            card.Setup(m => m.GetHashCode()).CallBase();
            card.Setup(m => m.Equals(card)).CallBase();
            return card.Object;
        }

        public List<ICard> GetTestCards()
        {
            List<ICard> cards = new List<ICard>
            {
                GetMockCard("A",Suit.SuitType.Diamond,13)
                ,GetMockCard("K",Suit.SuitType.Diamond,12)
                ,GetMockCard("Q",Suit.SuitType.Diamond,11)
                ,GetMockCard("J",Suit.SuitType.Diamond,10)
                ,GetMockCard("10",Suit.SuitType.Diamond,9)
                ,GetMockCard("9",Suit.SuitType.Diamond,8)
                ,GetMockCard("8",Suit.SuitType.Diamond,7)
                ,GetMockCard("7",Suit.SuitType.Diamond,6)
                ,GetMockCard("6",Suit.SuitType.Diamond,5)
                ,GetMockCard("5",Suit.SuitType.Diamond,4)
                ,GetMockCard("4",Suit.SuitType.Diamond,3)
                ,GetMockCard("3",Suit.SuitType.Diamond,2)
                ,GetMockCard("2",Suit.SuitType.Diamond,1)
                ,GetMockCard("8",Suit.SuitType.Diamond,7)
            };
            return cards;
        }
    }
}
