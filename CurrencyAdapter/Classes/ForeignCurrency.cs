using CurrencyAdapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyAdapter.Classes
{
    class ForeignCurrency : IForeignCurrency
    {
        public double amount { get; set; }
        public string currencyType { get; set; }
        public ForeignCurrency(double amount,string currencyType)
        {
            this.amount = amount;
            this.currencyType = currencyType;
        }
    }
}
