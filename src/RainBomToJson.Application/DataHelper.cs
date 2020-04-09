using System;
using System.Collections.Generic;
using System.Linq;
using RainBomToJson.DataManipulation;

namespace RainBomToJson.Application
{
    public static class DataHelper
    {
        public static string getFirstDate(List<RainRecord> records)
        {
            var sortedRecords = records.OrderBy(x => x.Date);
            return sortedRecords.First().Date.ToString("yyyy-MM-dd");
        }
        
        public static string getLastDate(List<RainRecord> records)
        {
            var sortedRecords = records.OrderBy(x => x.Date);
            return sortedRecords.Last().Date.ToString("yyyy-MM-dd");
        }
    }
}
