using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStockWidget1
{
    class StockValue
    {


        private string symbol;

        public string Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }

        private string prices;

        public string Prices
        {
            get { return prices; }
            set { prices = value; }
        }



    }
}
