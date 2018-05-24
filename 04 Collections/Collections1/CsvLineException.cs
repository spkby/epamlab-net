using System;

namespace Collections1
{
    public class CsvLineException : ArgumentException
    {
        private readonly string csvLine;
        private readonly string errorMessage;

        public CsvLineException(CsvLineException exception) : this(exception.csvLine, exception.errorMessage)
        {
        }

        public CsvLineException(string csvLine, ArgumentException exception) : this(csvLine, exception.ToString())
        {
        }

        public CsvLineException(string csvLine, string errorMessage)
        {
            this.csvLine = csvLine;
            this.errorMessage = errorMessage;
        }

        public override string ToString()
        {
            return (Constants.ErrorHead + Constants.ErrorDelimiter + csvLine + Constants.ErrorDelimiter + errorMessage);
        }
    }
}