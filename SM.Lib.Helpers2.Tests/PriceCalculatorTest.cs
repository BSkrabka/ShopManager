using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SM.Lib.Helpers;

namespace SM.Lib.Helpers.Tests
{
    [TestClass]
    [PexClass(typeof(PriceCalculator))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class PriceCalculatorTest
    {

        [PexMethod]
        public double CalculateClientPrice(
            double price,
            double marginValue,
            double vat
        )
        {
            double result = PriceCalculator.CalculateClientPrice(price, marginValue, vat);
            return result;
            // TODO: add assertions to method PriceCalculatorTest.CalculateClientPrice(Double, Double, Double)
        }
    }
}
