using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame;
using static CardGame.Suit.SuitType;

namespace Pinochle
{
    public class MeldType
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public int DisplayOrder { get; set; }
        public List<ICard> Cards { get; set; }

        public MeldType()
        {

        }

        public MeldType(string name, int value, int displayOrder, List<ICard> cards)
        {
            Name = name;
            Value = value;
            DisplayOrder = displayOrder;
            Cards = cards;
        }

        public override string ToString()
        {
            return Name;
        }

        #region "Equals"

        public static bool operator ==(MeldType a, MeldType b)
        {
            return (a.Equals(b) && (b.Equals(a)));
        }

        public static bool operator !=(MeldType a, MeldType b)
        {
            return !a.Equals(b);
        }

        public override bool Equals(object obj)
        {
            var meldType = obj as MeldType;
            bool returnVal = false;
            if (meldType.Name == Name)
            {
                returnVal = true;
            }
            return returnVal;
        }

        public override int GetHashCode()
        {
            //TODO: Investigate should this return hash of Value,Suit, & Rank?
            return Name.GetHashCode();
        }
        #endregion
    }
}
