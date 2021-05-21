using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Xml.Linq;
using System.Xml;

namespace MyStockWidget1
{
    class StockQuotes
    {
        public static XDocument FetchQuote(string symbol)
        {
            symbol = symbol.Trim();
            symbol = symbol.Replace(" ", "&stock=");
            symbol = symbol.Replace(",", "$stock");
            string url = "https://www.google.com/ig/api?stock=" + (symbol);
            return XDocument.Load(url);
        }
    }
}
