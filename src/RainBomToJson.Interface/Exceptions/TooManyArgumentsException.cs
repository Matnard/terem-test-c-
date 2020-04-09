using System;

namespace RainBomToJson.Interface
{
    public class TooManyArgumentsException : Exception
    {
        public TooManyArgumentsException()
        {
        }

        public TooManyArgumentsException(string message) : base(message)
        {
        }

        public TooManyArgumentsException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
