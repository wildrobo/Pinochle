using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame;

namespace Pinochle
{
    public class PinochleHand : Hand, IHand, IPinochleHand
    {
        public Suit.SuitType Trump { get; set; }
        

        public PinochleHand()
        {
            Trump = Suit.SuitType.None;
        }

        public int GetMaxBid()
        {
            int maxBid = 0;

            //TODO: Implement Actual Bid Logic
            Random rnd = new Random();
            maxBid = rnd.Next(20, 35);
            //End TODO

            return maxBid;
        }
        
        public IPinochleScore Score(Suit.SuitType trump)
        {
            IPinochleScore returnScore = new PinochleScore();

            return returnScore;
        }

        public int GetMeld()
        {
            var meld = new Meld();
            var meld = meld.Calculate(this);

            return 0;
        }

        public Suit.SuitType SelelctTrump(IHand hand)
        {
            Suit.SuitType suit = Suit.SuitType.None;
            //TODO:Logic to Select Suit
            return suit;
        }

        public List<ICard> PassToBidder(Suit.SuitType trump)
        {
            List<ICard> cardsToPass = new List<ICard>();
            //TODO: Logic to select Cards to Pass
            return cardsToPass;
        }

        public List<ICard> PassToNonBidder(Suit.SuitType trump)
        {
            List<ICard> cardsToPass = new List<ICard>();
            //TODO: Logic to select Cards to Pass
            return cardsToPass;
        }

        public int PlayCard(Suit.SuitType trump, List<IHand> cardsPlayed)
        {
            int meld = 0;
            //TODO: Logic to get next Card To Play
            return meld;
        }

        public new void Sort()
        {

        }

        public Suit.SuitType SelelctTrump()
        {
            throw new NotImplementedException();
        }
    }
}
