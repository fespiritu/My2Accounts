﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My2AccountsInAGlance.Model
{
    public class MarketIndex
    {
        public int Id { get; set; }
        public decimal Last { get; set; }
        public decimal Change { get; set; }
        public decimal PercentChange { get; set; }
        public decimal DayHigh { get; set; }
        public decimal DayLow { get; set; }
        public decimal YearHigh { get; set; }
        public decimal YearLow { get; set; }
        public decimal Open { get; set; }
        public decimal Volume { get; set; }
        public string Title { get; set; }
        public string Symbol { get; set; }
        public DateTime RetrievalDateTime { get; set; }
    }
}
