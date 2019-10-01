using CurrencyAdapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyAdapter.Services
{
    class ConversionService
    {
        public void PrintCurrency(ILocalCurrency localCurrency,IForeignCurrency foreignCurrency)
        {
            Console.WriteLine(localCurrency.Convert(foreignCurrency.amount));
        }
    }
}
