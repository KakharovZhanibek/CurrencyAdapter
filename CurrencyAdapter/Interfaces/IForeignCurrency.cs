using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyAdapter.Interfaces
{
    interface IForeignCurrency
    {
        double amount { get; set; }
        string currencyType { get; set; }
    }
}
