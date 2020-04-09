using System.IO;

namespace RainBomToJson.Application
{
    public class SystemHelper
    {
        public static bool IsCsv(string filepath)
        {
            return Path.GetExtension(filepath) == ".csv";
        }
    }
}
