using System;

namespace Collections1
{
    public class CsvLineException : ArgumentException
    {
        private string _cvsLine;

        public CsvLineException() : base()
        {
        }

        public CsvLineException(string csvLine) : base()
        {
            _cvsLine = csvLine;
        }

        public override string ToString()
        {
            return Constants.Error + Constants.Delimiter + _cvsLine + Constants.Delimiter + base.Message;
        }
    }
}