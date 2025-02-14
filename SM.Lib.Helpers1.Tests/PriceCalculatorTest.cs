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
        public double MarginPrice(double price, double marginValue)
        {
            double result = PriceCalculator.MarginPrice(price, marginValue);
            return result;
            // TODO: add assertions to method PriceCalculatorTest.MarginPrice(Double, Double)
        }
    }
}
