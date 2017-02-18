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
            Value = Value;
            DisplayOrder = DisplayOrder;
            Cards = cards;
        }
    }
}
