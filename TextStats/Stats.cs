using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStats
{
    public class Stats 
    {
        public int TotalLines { get; set; }
        public int LineCountExact { get; set; }
        public int LineCountIgnoreCase { get; set; }

        public Stats(int totalLines, int lineCountExact, int lineCountIgnoreCase)
        {
            TotalLines = totalLines;
            LineCountExact = lineCountExact;
            LineCountIgnoreCase = lineCountIgnoreCase;
        }

        public override string ToString()
        {
            return $@"
Ant linjer: {TotalLines} 
Ant med eksakt treff: {LineCountExact} 
Ant med treff sett bort fra casing: {LineCountIgnoreCase}";
        }
    }
}
