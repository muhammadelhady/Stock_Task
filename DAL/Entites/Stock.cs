using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entites
{
    public class Stock : Audit
    {
        public string StockCode { get; set; }
        public double OldPrice { get; set; }
        public double LastPrice { get; set; }
    }
}
