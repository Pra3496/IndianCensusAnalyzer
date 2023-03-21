using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyzerProgram
{
    public class CustomException : Exception
    {
        public enum ExceptionType
        {
            FILE_NOT_FOUND,
            CSV_FILE_NOT_FOUND,
            INCORRECT_DELIMETER,
            INCORRECT_HEADER
        }

        public ExceptionType Type;

        public CustomException(ExceptionType type,string message) : base(message)
        {
            this.Type = type;
        }
    }
}
