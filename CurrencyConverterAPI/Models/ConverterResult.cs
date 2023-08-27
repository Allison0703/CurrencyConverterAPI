using System.Globalization;

namespace CurrencyConverterAPI.Models
{
    public class ConverterResult
    {
        private decimal _amount = 0;

        public ConverterResult(string msg, decimal amount)
        {
            this._amount = amount;
            this.msg = msg;
        }

        public string msg { get; set; }
        public string amount
        {
            get
            {
                return _amount.ToString("C", new CultureInfo("en-US"));
            }
        }
    }
}
