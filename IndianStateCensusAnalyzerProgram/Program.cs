using System.Security.Cryptography.X509Certificates;

namespace IndianStateCensusAnalyzerProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"F:\RPF Batch 256\IndianStateCensusAnalyzerProgram\IndianStateCensusAnalyzerProgram\files\StateCensusData.csv";

            string fileStateCodePath = @"F:\RPF Batch 256\IndianStateCensusAnalyzerProgram\IndianStateCensusAnalyzerProgram\files\StateCode.csv";

          

            StateCensesAnalyzer stateCensesAnalyzer = new StateCensesAnalyzer();

            int uu = stateCensesAnalyzer.ReadStateCensusData(filePath);
            Console.WriteLine(uu);
            
        }
    }
}