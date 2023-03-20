using System.Security.Cryptography.X509Certificates;

namespace IndianStateCensusAnalyzerProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"F:\RPF Batch 256\IndianStateCensusAnalyzerProgram\IndianStateCensusAnalyzerProgram\files\StateCensusData.csv";

            CsvCencus csvCensus = new CsvCencus();

            csvCensus.ReadStateCensusData(filePath);
        }
    }
}