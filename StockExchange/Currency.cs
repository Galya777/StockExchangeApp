using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchange
{
    public class Currency
    {
       private Money currencyCode;
        private decimal exchange;
        static Random random=new Random();

        public Currency(Money money, decimal exchange)
        {
            this.currencyCode = money;
            this.exchange = exchange;
        }
        public Currency()
        {
            this.currencyCode = Money.EUR_USD;
            this.exchange =(decimal) 1.13;
        }
        public Currency(Currency other)
        {
            this.currencyCode = other.currencyCode;
            this.exchange = other.exchange;
        }
        public Money CurrencyCode { get { return currencyCode; } set { currencyCode=value; } }

        public decimal Exchange { get {return exchange; } set {exchange=value>0?value:0; } }

        public void ChangeExchangeRate()
        {
            double value = (double)exchange * 0.03;
            double min = (double)exchange - value;
                double max = (double)exchange + value;
            double exchangeValue = random.NextDouble()*(max- min)+ min;
            exchange *= (decimal)exchangeValue;
        }
        public override string ToString()
        {
            return string.Format( "%.4d, %.4d %d:%d:%d", currencyCode, exchange, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
        }

    }
}
