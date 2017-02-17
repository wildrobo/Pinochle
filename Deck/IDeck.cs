using System.Collections.Generic;

namespace Core
{
    public interface IDeck
    {
        List<Card> Cards { get; set; }

        void Shuffle();
    }
}