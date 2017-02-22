using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CardGame.Suit;

namespace CardGame
{
    public class Card : ICard
    {
        public String Value { get; set; }
        public SuitType Suit { get; set; }
        public int Rank { get; set; }
        public IPlayer PlayedBy { get; set; }
        public int OrderPlayed { get; set; }

        private string _key;

        public Card(string value, SuitType suit, int rank = 0)
        {
            Value = value;
            Suit = suit;
            Rank = rank;
            _key = value + Enum.GetName(typeof(SuitType), suit) + rank.ToString();
        }

        #region "Equals"
        public static bool operator == (Card card1, ICard card2)
        {
            return card1.Equals(card2);
        }

        public static bool operator != (Card card1, ICard card2)
        {
            return !card1.Equals(card2);
        }

        public override bool Equals(object obj)
        {
            var card = obj as ICard;
            bool returnVal = false;
            if (card.Value == Value
                && card.Suit == Suit
                && card.Rank == Rank)
            {
                returnVal = true;
            }
            return returnVal;
        }

        public override int GetHashCode()
        {
            return _key.GetHashCode();
        }
        #endregion

        //public class CardComparer : IComparer<ICard>
        //{
        public int CompareTo(ICard card2)
            {
                return Rank.CompareTo(card2.Rank);
            }
        //}

        public override string ToString()
        {
            return _key;
        }


    }
}
