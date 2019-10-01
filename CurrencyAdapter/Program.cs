using CurrencyAdapter.Classes;
using CurrencyAdapter.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new ConversionService();
            var local = new LocalCurrency(400,"KZT");
        }
    }
}
