using IndianStateCensusAnalyzerProgram;

namespace indiancsvStateCodeTest
{
    public class StateCodeTest
    {
        public static string filePath = @"F:\RPF Batch 256\IndianStateCensusAnalyzerProgram\IndianStateCensusAnalyzerProgram\files\StateCode.csv";

        public static string filePathError = @"F:\RPF Batch 256\IndianStateCensusAnalyzerProgram\IndianStateCensusAnalyzerProgram\files\StateCode111.csv";

        public static string fileTypeError = @"F:\RPF Batch 256\IndianStateCensusAnalyzerProgram\IndianStateCensusAnalyzerProgram\files\StateCode1.txt";

        public static string FileDelimiterIncorrect = @"F:\RPF Batch 256\IndianStateCensusAnalyzerProgram\IndianStateCensusAnalyzerProgram\files\StateCodeDilimit.csv";

        public static string FileHeaderIncorrect = @"F:\RPF Batch 256\IndianStateCensusAnalyzerProgram\IndianStateCensusAnalyzerProgram\files\StateCodeHeader.csv";


        CsvStateCode csvStateCode = new CsvStateCode();

        


        [Test]
        public void Test1()
        {
            Assert.AreEqual(csvStateCode.ReadStateCodeData(filePath), csvStateCode.ReadStateCodeData(filePath));
        }

        [Test]
        public void GivenStateCensusIncorrectCSVfile()
        {
            try
            {
                int record = csvStateCode.ReadStateCodeData(filePathError);
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
                int record = csvStateCode.ReadStateCodeData(fileTypeError);
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
                csvStateCode.ReadStateCodeData(FileDelimiterIncorrect);
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

                csvStateCode.ReadStateCodeData(FileHeaderIncorrect,Header);
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("Incorrect Header", ex.Message);
            }
        }
    }
}