using System.Collections.Generic;

namespace Pinochle
{
    public interface IPinochleScore
    {
        IPinocleScoreResult Hand { get; set; }
        List<IPinocleScoreResult> Results { get; set; }
        int Value { get; set; }
    }
}