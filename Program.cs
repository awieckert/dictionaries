using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Dictionary<string, string> stockBook = new Dictionary<string, string>()
            {
              {"GM", "General Motors"},
              {"NVD", "Nvidia"},
              {"FID", "Fidelity Contrafound"}
            };

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>()
            {
              ("GM", 25, 342.1),
              ("NVD", 110, 123),
              ("FID", 12, 456.9),
              ("NVD", 90, 123),
              ("GM", 234, 342.1),
            };

            Dictionary<string, double> stockPrices = new Dictionary<string, double>();

            foreach ((string ticker, int shares, double price) item in purchases)
            {
                if (!stockPrices.ContainsKey(stockBook[item.ticker])) {
                  stockPrices[stockBook[item.ticker]] = (item.shares * item.price);
                } else {
                  stockPrices[stockBook[item.ticker]] += (item.shares * item.price);
                }
            }

            foreach (KeyValuePair<string, double> stocks in stockPrices)
            {
                Console.WriteLine($"{stocks.Key}: ${stocks.Value}");
            }
        }
    }
}
