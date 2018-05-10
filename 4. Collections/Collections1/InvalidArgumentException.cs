using System;

namespace Collections1
{
    public class InvalidArgumentException : ArgumentException
    {
        //private readonly string _errorMessage;
        
        public InvalidArgumentException(string errorMessage) : base(errorMessage)
        {
        }

        public override string ToString()
        {
            return Message;
        }
    }
}