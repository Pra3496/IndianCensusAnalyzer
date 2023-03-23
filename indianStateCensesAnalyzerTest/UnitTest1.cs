using IndianStateCensusAnalyzerProgram;

namespace indianStateCensesAnalyzerTest
{
    public class Tests
    {
        public static string filePath = @"F:\RPF Batch 256\IndianStateCensusAnalyzerProgram\IndianStateCensusAnalyzerProgram\files\StateCensusData.csv";

        public static string filePathError = @"F:\RPF Batch 256\IndianStateCensusAnalyzerProgram\IndianStateCensusAnalyzerProgram\files\StateCensusData11.csv";

        public static string fileTypeError = @"F:\RPF Batch 256\IndianStateCensusAnalyzerProgram\IndianStateCensusAnalyzerProgram\files\StateCensusData.txt";

        public static string FileDelimiterIncorrect = @"F:\RPF Batch 256\IndianStateCensusAnalyzerProgram\IndianStateCensusAnalyzerProgram\files\StateCensusDataDlim.csv";

        public static string FileHeaderIncorrect = @"F:\RPF Batch 256\IndianStateCensusAnalyzerProgram\IndianStateCensusAnalyzerProgram\files\StateCensusDataDlim.csv";

        
        

        StateCensesAnalyzer stateCensesAnalyzer = new StateCensesAnalyzer();


        [Test]
        public void Test1()
        {
            Assert.AreEqual(29, stateCensesAnalyzer.ReadStateCensusData(filePath));
        }

        public void GivenStateCensusIncorrectCSVfile()
        {
            try
            {
                int record = stateCensesAnalyzer.ReadStateCensusData(filePathError);
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect file path");
            }
        }

      

    }
}