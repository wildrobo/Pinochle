using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinochle
{
    public class PinocleScoreResult : IPinocleScoreResult
    {
        

        public int TotalValue { get; set; }
       // public ScoreResultType Type { get; set; }
        public List<IPinochleCard> MissingCards { get; set; }



    }

}
