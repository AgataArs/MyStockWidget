using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Data.Analysis;
using System.Net;

//xDDDDDDDDDDDDDD


namespace MyStockWidget1
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            AVConnection conn = new AVConnection("demo");
            conn.SaveCSVFromURL("IBM");
            DataFrame df = DataFrame.LoadCsv("stockdata.csv");
        }

        public class AVConnection
        {
            private readonly string _apiKey;

            public AVConnection(string apiKey)
            {
                this._apiKey = apiKey;
            }

            public void SaveCSVFromURL(string symbol)
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://" + $@"www.alphavantage.co/query?function=TIME_SERIES_DAILY&symbol={symbol}&apikey={this._apiKey}&datatype=csv");
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

                StreamReader sr = new StreamReader(resp.GetResponseStream());
                string results = sr.ReadToEnd();
                sr.Close();
                File.WriteAllText("stockdata.csv", results);
            }

          

        }

        

       

    

}
}
