using System;

namespace CurrencyConverterAPI.Models
{
    public enum CType
    {
        TWD, JPY, USD
    }

    public class CurrencyConverter
    {
        public CType source { get; set; }
        public CType target { get; set; }
        public decimal amount { get; set; }

        public decimal ToConvert()
        {
            decimal rate = 0;

            RateList rateList = new RateList();
            var exchangeRate = rateList.GetType().GetProperty("R" + Enum.GetName(typeof(CType), source)).GetValue(rateList);
            rate = (decimal)exchangeRate.GetType().GetProperty(Enum.GetName(typeof(CType), target)).GetValue(exchangeRate);
            return Decimal.Round(amount * rate,2, MidpointRounding.AwayFromZero);
        }
    }

    /// <summary>
    /// 匯率表
    /// </summary>
    public class RateList
    {
        public static ExchangeRate RTWD { get; } = new ExchangeRate { TWD = 1M, JPY = 3.669M, USD = 0.03281M };
        public static ExchangeRate RJPY { get; } = new ExchangeRate { TWD = 0.26956M, JPY = 1M, USD = 0.00885M };
        public static ExchangeRate RUSD { get; } = new ExchangeRate { TWD = 30.444M, JPY = 111.801M, USD = 1M };
    }

    public class ExchangeRate
    {
        public decimal TWD { get; set; }
        public decimal JPY { get; set; }
        public decimal USD { get; set; }
    }
}
