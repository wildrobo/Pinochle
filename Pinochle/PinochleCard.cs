using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame;
using static CardGame.Suit;

namespace Pinochle
{
    public class PinochleCard : Card, ICard, IPinochleCard, IComparable<IPinochleCard>
    {
        public bool IsTrump { get; set; }
        public PinochleCard(string value, SuitType suit, int rank, bool isTrump = false, int orderPlayed = 0) : base(value, suit, rank)
        {
            IsTrump = isTrump;
            OrderPlayed = orderPlayed;
        }

        public void Sort()
        {
            throw new NotImplementedException();
        }

        #region "GreaterThan LessThan"
        //TODO:Implement <= an >=
        public static bool operator >(PinochleCard card1, IPinochleCard card2)
        {
            return card1.CompareTo(card2) > 0;
        }

        public static bool operator <(PinochleCard card1, IPinochleCard card2)
        {
            return card1.CompareTo(card2) < 0;
        }

        public int CompareTo(IPinochleCard card2)
        {
            if (IsTrump && !card2.IsTrump)
            {
                return 1;
            }
            else if (card2.IsTrump && !IsTrump)
            {
                return -1;
            }
            else
            {
                //TODO:figure out how to call base compare
                return Rank.CompareTo(card2.Rank);
            }
        }
        #endregion

        #region "Equals"

        public static bool operator ==(PinochleCard card1, IPinochleCard card2)
        {
            return (card1.Equals(card2) && (card1.Equals(card2)));
        }

        public static bool operator !=(PinochleCard card1, IPinochleCard card2)
        {
            return !card1.Equals(card2);
        }

        public override bool Equals(object obj)
        {
            var card = obj as IPinochleCard;
            bool returnVal = false;
            if (card.IsTrump == IsTrump)
            {
                returnVal = true;
            }
            return returnVal;
        }

        public override int GetHashCode()
        {
            //TODO: Investigate should this return hash of Value,Suit, & Rank?
            return base.GetHashCode();
        }
        #endregion "Equals"
    }
}
