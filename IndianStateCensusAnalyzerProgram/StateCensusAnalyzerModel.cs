using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyzerProgram
{
    public class StateCensusAnalyzerModel
    {
        public string State { get; set; }

        public string Population { get; set; }

        public string AreaInSqKm { get; set; }

        public string DensityPerSqKm { get; set; }
    }
}
