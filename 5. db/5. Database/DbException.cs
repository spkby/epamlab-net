using System;

namespace Database
{
    public class DbException : Exception
    {
        public readonly string message;

        public DbException(string message) : base()
        {
            this.message = message;
        }

        public override string ToString()
        {
            return message;
        }
    }
}