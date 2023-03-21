using System.Security.Cryptography.X509Certificates;

namespace IndianStateCensusAnalyzerProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"F:\RPF Batch 256\IndianStateCensusAnalyzerProgram\IndianStateCensusAnalyzerProgram\files\StateCensusData.csv";

            string fileStateCodePath = @"F:\RPF Batch 256\IndianStateCensusAnalyzerProgram\IndianStateCensusAnalyzerProgram\files\StateCode.csv";

            CsvStateCencus csvCensus = new CsvStateCencus();

            csvCensus.ReadStateCensusData(filePath);

            StateCensesAnalyzer stateCensesAnalyzer = new StateCensesAnalyzer();

            stateCensesAnalyzer.ReadStateCensusData(filePath);

            // https://go.microsoft.com/fwlink/?linkid=2043154
        }
    }
}