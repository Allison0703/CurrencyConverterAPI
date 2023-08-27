using System;
using CurrencyConverterAPI.Models;
using System.Globalization;

namespace CurrencyConverterAPI
{
    public class Services
    {
        public decimal CurrencyConvert(string source, string target, string amount)
        {
            try
            {
                CType sourceType = (CType)Enum.Parse(typeof(CType), source, true);
                CType targetType = (CType)Enum.Parse(typeof(CType), target, true);

                NumberStyles style = NumberStyles.Currency;
                decimal amountM = Decimal.Parse(amount, style, new CultureInfo("en-US"));

                CurrencyConverter cc = new CurrencyConverter { source = sourceType, target = targetType, amount = amountM };
                return cc.ToConvert();
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
