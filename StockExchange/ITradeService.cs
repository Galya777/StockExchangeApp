﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchange
{
    public interface ITradeService
    {
       Currency[] Trade { get; }
          
    }
}
