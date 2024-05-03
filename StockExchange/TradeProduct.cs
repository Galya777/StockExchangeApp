using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchange
{
    public class TradeProduct : ITradeService
    {
        private Currency[] moneyToTrade;

        public Currency[] MoneyToTrade { get { lock (moneyToTrade) { return moneyToTrade; } }
                set { lock (moneyToTrade) { moneyToTrade = value; } } }

        public TradeProduct(){
            moneyToTrade = new Currency[4];
            moneyToTrade[0].CurrencyCode=(Money)0;
            moneyToTrade[0].Exchange=(decimal)1.130;
            moneyToTrade[1].CurrencyCode = (Money)1;
            moneyToTrade[1].Exchange = (decimal)1.65;
            moneyToTrade[2].CurrencyCode = (Money)2;
            moneyToTrade[2].Exchange = (decimal)107.102;
            moneyToTrade[3].CurrencyCode = (Money)3;
            moneyToTrade[3].Exchange = (decimal)34.37;
        }

        public Currency[] Trade => moneyToTrade;
    }
}
