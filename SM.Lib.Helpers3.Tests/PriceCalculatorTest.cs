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
        public void CalculateVatPriceVoid(double price, double vat)
        {
            PriceCalculator.CalculateVatPriceVoid(price, vat);
            // TODO: add assertions to method PriceCalculatorTest.CalculateVatPriceVoid(Double, Double)
        }
    }
}
