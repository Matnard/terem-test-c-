using System;
using System.IO;
using RainBomToJson.Application;
using RainBomToJson.Application.Exceptions;
using RainBomToJson.DataManipulation;

namespace RainBomToJson.Interface
{
    public class Bootstrapper
    {
        public static void Start(string[] args)
        {
            var filepath = args.Length switch
            {
                0 => throw new TooFewArgumentsException(message: "Please provide path to .csv file"),
                1 => args[0],
                _ => throw new TooManyArgumentsException(message:"Please only provide one argument.")
            };

            if(!SystemHelper.IsCsv(filepath))
            {
                throw new WrongFileTypeException(message: "Please provide a .csv file");
            }

            using var reader = new StreamReader(filepath);
            ParseRainBom.Parse(reader);
        }
    }
}
