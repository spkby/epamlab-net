using System;

namespace Collections1
{
    public class NonpositiveArgumentException : ArgumentException
    {
        private readonly int value;
        private readonly Fields.FieldsPosition field;

        public NonpositiveArgumentException(int value, Fields.FieldsPosition field)
        {
            this.value = value;
            this.field = field;
        }

        public override string ToString()
        {
            return (Constants.ErrorNonpositiveHead + value
                                                   + Constants.ErrorNonpositiveBody + field
                                                   + Constants.ErrorNonpositiveTail);
        }
    }
}