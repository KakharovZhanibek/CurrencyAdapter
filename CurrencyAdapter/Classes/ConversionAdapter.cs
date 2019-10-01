using CurrencyAdapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyAdapter.Classes
{
    class ConversionAdapter : ILocalCurrency
    {
        public IForeignCurrency foreignCurrency;
        public ConversionAdapter(ForeignCurrency foreignCurrency)
        {
            this.foreignCurrency = foreignCurrency;
        }

        public double amount { get; set; }
        public string currencyType { get; set; }

        public double Convert(double value)
        {
            return value * 1.5;
        }
    }
}
