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

        
        CsvStateCencus csvCensus = new CsvStateCencus();

        StateCensesAnalyzer stateCensesAnalyzer = new StateCensesAnalyzer();


        [Test]
        public void Test1()
        {
            Assert.AreEqual(csvCensus.ReadStateCensusData(filePath), stateCensesAnalyzer.ReadStateCensusData(filePath));
        }

        [Test]
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

        [Test]
        public void GivenStateCensusIncorrectFileTypeIncorrect()
        {
            try
            {
                int record = stateCensesAnalyzer.ReadStateCensusData(fileTypeError);
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(ex.Message, "File Type is Incorrect");
            }
        }

        [Test]
        public void GivenIncorrectDelimeter_ShouldReturnCustomeException()
        {
            try
            {
                csvCensus.ReadStateCensusData(FileDelimiterIncorrect);
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("Incorrect Delimiter", ex.Message);
            }
        }

        [Test]
        public void GivenIncorrectHeader_ShouldReturnCustomeException()
        {
            try
            {
                string Header = "State,Population,AreaInSqKm,DensityPerSqKm";

                csvCensus.ReadStateCensusData(FileHeaderIncorrect, Header);
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("Incorrect Header", ex.Message);
            }
        }
    }
}