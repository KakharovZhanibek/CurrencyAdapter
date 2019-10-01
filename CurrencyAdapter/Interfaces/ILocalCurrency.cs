using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyAdapter.Interfaces
{
    interface ILocalCurrency
    {
        double amount { get; set; }
        string currencyType { get; set; }
        double Convert(double value);

    }
}
