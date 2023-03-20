
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyzerProgram
{
    internal class CsvCencus
    {
        public void ReadStateCensusData(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            {
                using(var csv = new CsvReader(reader,CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<StateCensusAnalyzerModel>().ToList();

                    foreach(var record in records)
                    {
                        Console.WriteLine($"{record.State} {record.Population} {record.AreaInSqKm} {record.DensityPerSqKm}");
                    }
                }
            }
        }
    }
}


