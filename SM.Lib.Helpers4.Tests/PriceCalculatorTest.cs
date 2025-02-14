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
        public bool VatIsNotNull(double price, double vat)
        {
            bool result = PriceCalculator.VatIsNotNull(price, vat);
            return result;
            // TODO: add assertions to method PriceCalculatorTest.VatIsNotNull(Double, Double)
        }
    }
}
