using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server_Thread
{
    class Stock
    {
        private string symbol;
        private string companyName;
        private double stockPrice;

        public string gCompanyName
        {
            get { return companyName; }
        }

        public string gSymbol
        {
            get { return symbol; }
        }

        public double gStockPrice
        {
            get { return stockPrice; }
        }

        public Stock(string Symbol, string Name, double Price)
        {
            this.stockPrice = Price;
            this.symbol = Symbol;
            this.companyName = Name;
        }

        public string StockInfo()
        {
            return "\nStock Symbol: " + this.gSymbol + "\nCompany: " + this.gCompanyName 
                + "\nStock Price: " + this.gStockPrice;
        }
    }
}
