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
            List<ICard> copyOfCards = Cards.ConvertAll(x => x);

            //TODO: Think there is a faster way to do this with LINQ
            int indexOfSelectedCard = 0;
            int cardCounter = 0;
            int cardsFound = 0;
            var returnVal = false;

            do
            {
                indexOfSelectedCard = copyOfCards.IndexOf(cardsToMatch[cardCounter]);
                if (indexOfSelectedCard >= 0)
                {
                    cardsFound ++;
                    copyOfCards.RemoveAt(indexOfSelectedCard);
                }
                cardCounter++;
            } while (indexOfSelectedCard >= 0 && cardCounter < cardsToMatch.Count);

            if (cardsFound == cardsToMatch.Count())
            {
                returnVal = true;
            }
            else
            {
                returnVal = false;
            }

            return returnVal;
        }

    }
}
