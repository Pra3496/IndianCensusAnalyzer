using IndianStateCensusAnalyzerProgram;

namespace indianStateCensesAnalyzerTest
{
    public class Tests
    {
        public static string filePath = @"F:\RPF Batch 256\IndianStateCensusAnalyzerProgram\IndianStateCensusAnalyzerProgram\files\StateCensusData.csv";

        public static string filePathError = @"F:\RPF Batch 256\IndianStateCensusAnalyzerProgram\IndianStateCensusAnalyzerProgram\files\StateCensusData11.csv";

        public static string fileTypeError = @"F:\RPF Batch 256\IndianStateCensusAnalyzerProgram\IndianStateCensusAnalyzerProgram\files\StateCensusData.txt";

        CsvCencus csvCensus = new CsvCencus();

        StateCensesAnalyzer stateCensesAnalyzer = new StateCensesAnalyzer();


        [Test]
        public void Test1()
        {
            Assert.AreEqual(csvCensus.ReadStateCensusData(filePath), stateCensesAnalyzer.ReadStateCensusData(filePath));
        }

        
}