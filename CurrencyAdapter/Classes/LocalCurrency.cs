using CurrencyAdapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyAdapter.Classes
{
    class LocalCurrency : ILocalCurrency
    {
        public double amount { get ; set ; }
        public string currencyType { get; set; }

        public LocalCurrency(double amount,string currencyType)
        {
            this.amount = amount;
            this.currencyType = currencyType;
        }
        public double Convert(double value)
        {
            return 0;///
        }
    }
}
