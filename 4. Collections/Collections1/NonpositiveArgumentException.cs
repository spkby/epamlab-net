﻿using System;

namespace Collections1
{
    public class NonpositiveArgumentException : ArgumentException
    {
        private readonly int _value;
        private readonly Fields.FieldsPosition _field;

        public NonpositiveArgumentException(int value, Fields.FieldsPosition field)
        {
            _value = value;
            _field = field;
        }

        public override string ToString()
        {
            return (Constants.ErrorNonpositiveHead + _value
                                                   + Constants.ErrorNonpositiveBody + _field
                                                   + Constants.ErrorNonpositiveTail);
        }
    }
}