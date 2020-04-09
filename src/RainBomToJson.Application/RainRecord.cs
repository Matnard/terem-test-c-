﻿using System;

 namespace RainBomToJson.DataManipulation
{
    public class RainRecord
    {
        public string ProductCode { get; set; }
        public string BureauNumber { get; set; }
        public string RainfallAmount { get; set; }
        public int Period { get; set; }
        public string Quality { get; set; }
        
        public DateTime Date { get; set; }
    }
}
