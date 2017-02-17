using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinochle
{
    public class PinochleScore : IPinochleScore
    {
        public List<IPinocleScoreResult> Results { get; set; }
        public IPinocleScoreResult Hand { get; set; }
        public int Value { get; set; }

        


    }
}
