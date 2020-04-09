﻿using System;
 using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
 using RainBomToJson.Application;

 namespace RainBomToJson.DataManipulation
{
    public static class ParseRainBom
    {
        public static List<RainRecord> Parse(StreamReader reader)
        {
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = new List<RainRecord>();
                csv.Read();
                csv.ReadHeader();
                while (csv.Read())
                {
                    var year = csv.GetField("Year");
                    var month = csv.GetField("Month");
                    var day = csv.GetField("Day");
                    var record = new RainRecord()
                    {
                        ProductCode  = csv.GetField("Product code"),
                        BureauNumber  = csv.GetField("Bureau of Meteorology station number"),
                        RainfallAmount  = csv.GetField("Rainfall amount (millimetres)"),
                        Period = csv.GetField<int>("Period over which rainfall was measured (days)"),
                        Quality  = csv.GetField("Quality"),
                        Date = DateTime.ParseExact($"{year}-{month}-{day}", "yyyy-MM-dd", CultureInfo.InvariantCulture)
                    };
                    
                    if (!String.IsNullOrEmpty(record.RainfallAmount.Trim()))
                    {
                        records.Add(record);
                    }
                }

                var first = DataHelper.getFirstDate(records);
                var last = DataHelper.getLastDate(records);
                
                return records;
            }
        }
    }
}
