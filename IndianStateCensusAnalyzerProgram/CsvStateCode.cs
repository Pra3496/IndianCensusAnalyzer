using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IndianStateCensusAnalyzerProgram.CustomException;

namespace IndianStateCensusAnalyzerProgram
{
    public class CsvStateCode
    {
        public int ReadStateCodeData(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new CustomException(ExceptionType.FILE_NOT_FOUND, "Incorrect file path");
            }

            if (!filePath.EndsWith(".csv"))
            {
                throw new CustomException(ExceptionType.CSV_FILE_NOT_FOUND, "File Type is Incorrect");
            }

            var csvfile = File.ReadAllLines(filePath);
            string header = csvfile[0];



            if (header.Contains("/"))
            {
                throw new CustomException(ExceptionType.INCORRECT_DELIMETER, "Incorrect Delimiter");
            }

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<StateCodeModel>().ToList();

                foreach (var record in records)
                {
                    // SrNo,State,Name,TIN,StateCode 
                    Console.WriteLine(record);
                }

                return records.Count() - 1;
            }
        }

        public bool ReadStateCodeData(string filePath, string actualHeader)
        {
            var csvfile = File.ReadAllLines(filePath);
            string header = csvfile[0];

            if (!header.Equals(actualHeader))
                return true;
            else
                throw new CustomException(ExceptionType.INCORRECT_HEADER, "Incorrect Header");

        }
    }
}
