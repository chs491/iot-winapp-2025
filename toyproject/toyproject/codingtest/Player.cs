using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace codingtest
{
    public class Player
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int Age { get; set; }
        public int AtBats { get; set; }
        public int Hits { get; set; }
        public int Walks { get; set; }
        public int Doubles { get; set; }
        public int Triples { get; set; }
        public int HomeRuns { get; set; }

        public double AVG => (AtBats != 0 ? (double)Hits / AtBats : 0);
        public double OBP => AtBats + Walks != 0 ? (double)(Hits + Walks) / (AtBats + Walks) : 0;
        public double SLG => AtBats != 0 ?
            (double)(Hits + Doubles + 2 * Triples + 3 * HomeRuns) / AtBats : 0;
        public double OPS => OBP + SLG;

        public string AVGFormatted => AVG.ToString("0.000");
        public string OPSFormatted => OPS.ToString("0.000");
    }

}
