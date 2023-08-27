using Microsoft.VisualStudio.TestTools.UnitTesting;
using CurrencyConverterAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverterAPI.Tests
{
    [TestClass()]
    public class ServicesTests
    {
        [TestMethod()]
        public void CurrencyConvertTest()
        {
            var expected = 170496.53M;

            Services services = new Services();
            var actual = services.CurrencyConvert("USD", "JPY", "$1,525");

            Assert.AreEqual(expected, actual);
        }
    }
}