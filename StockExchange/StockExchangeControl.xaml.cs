using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StockExchange
{
    /// <summary>
    /// Interaction logic for StockExchangeControl.xaml
    /// </summary>
    public partial class StockExchangeControl : UserControl
    {
        static Currency[] currency;
        public delegate void Traders(Currency[] currencies);
        event Traders Broker;
       Thread thread;
        
        public StockExchangeControl()
        {
            InitializeComponent();
            
            thread.Start();
            RunStockExchange();
        }
        public void RunStockExchange()
        {
            
            while (true)
            {
                Broker.Invoke(currency);
                Thread.Sleep(1000);
                Box.Text = currency.ToString();
            }

        }
    }
}
