using System;

namespace RainBomToJson.Interface
{
    public class TooFewArgumentsException : Exception
    {
        public TooFewArgumentsException()
        {
        }

        public TooFewArgumentsException(string message) : base(message)
        {
        }

        public TooFewArgumentsException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
