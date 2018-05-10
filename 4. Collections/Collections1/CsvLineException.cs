using System;

namespace Collections1
{
    public class CsvLineException : ArgumentException
    {
        private readonly string _cvsLine;
        private readonly string _errorMessage;

        public CsvLineException(CsvLineException exception) : this(exception._cvsLine, exception._errorMessage)
        {
        }
        
        public CsvLineException(string csvLine, ArgumentException exception) : this(csvLine, exception.ToString())
        {
        }

        public CsvLineException(string csvLine, string errorMessage)
        {
            _cvsLine = csvLine;
            _errorMessage = errorMessage;
        }

        public override string ToString()
        {
            return Constants.ErrorHead + Constants.ErrorDelimiter + _cvsLine + Constants.ErrorDelimiter + _errorMessage;
        }
    }
}