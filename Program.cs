using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("FDX", "Fedex");
            stocks.Add("GOOAV", "Google");
            stocks.Add("AMZN", "Amazon");

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

            purchases.Add((ticker: "GM", shares: 150, price: 23.21));
            purchases.Add((ticker: "GM", shares: 32, price: 17.87));
            purchases.Add((ticker: "GM", shares: 80, price: 19.02));
            purchases.Add((ticker: "FDX", shares: 52, price: 218.51));
            purchases.Add((ticker: "FDX", shares: 31, price: 208.95));
            purchases.Add((ticker: "GOOAV", shares: 16, price: 940.81));
            purchases.Add((ticker: "GOOAV", shares: 12, price: 934.67));
            purchases.Add((ticker: "CAT", shares: 34, price: 106.92));
            purchases.Add((ticker: "AMZN", shares: 5, price: 978.76));
            purchases.Add((ticker: "AMZN", shares: 8, price: 963.54));
            

            /* 
            Define a new Dictionary to hold the aggregated purchase information.
            - The key should be a string that is the full company name.
            - The value will be the valuation of each stock (price*amount)
            */
            Dictionary<string, double> totalOwnershipReport = new Dictionary<string, double>();

            foreach((string ticker, int shares, double price) purchase in purchases)
            {
                // Does the company name key already exist in the report dictionary?

                if (totalOwnershipReport.ContainsKey(stocks[purchase.ticker]))
                {
                    // If it does, update the total valuation
                    totalOwnershipReport[stocks[purchase.ticker]] += purchase.price * purchase.shares;

                }
                else
                {
                // If not, add the new key and set its value
                 totalOwnershipReport.Add(stocks[purchase.ticker], purchase.price * purchase.shares);
                }


            }

            //wright it out
            foreach(var item in totalOwnershipReport)
            {
                Console.WriteLine($"{item.Key} : ${item.Value}");
            }
        }
    }
}
