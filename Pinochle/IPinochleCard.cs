using System.Collections.Generic;
using CardGame;

namespace Pinochle
{
    public interface IPinochleCard : ICard
    {
        bool IsTrump { get; set; }
        int CompareTo(IPinochleCard card2);
    }
}