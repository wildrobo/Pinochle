using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Hand : IHand
    {
        public List<ICard> Cards { get; set; }
        public List<ICard> KnownCardsPlayed { get; set; }
        public Player Player { get; set; }

        public Hand()
        {
            Cards = new List<ICard>();
        }

        public void Sort()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Hand hand)
        {
            throw new NotImplementedException();
            
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public bool Contains(List<ICard> cardsToMatch)
        {        
            return cardsToMatch.Except(Cards).Any();
        }

    }
}
