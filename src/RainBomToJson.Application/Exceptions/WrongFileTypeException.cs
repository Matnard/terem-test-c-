﻿using System;

 namespace RainBomToJson.Application.Exceptions
{
    public class WrongFileTypeException: Exception
    {
        public WrongFileTypeException(string message) : base(message)
        {
        }
    }
}
