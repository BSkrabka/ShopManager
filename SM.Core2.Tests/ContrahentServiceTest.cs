using SM.Core.Models.Requests;
using SM.Data.Models.Shop;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SM.Core.Services;

namespace SM.Core.Services.Tests
{
    [TestClass]
    [PexClass(typeof(ContrahentService))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ContrahentServiceTest
    {

        [PexMethod]
        public Contrahent MapToEntityModel([PexAssumeUnderTest] ContrahentService target, ContrahentRequest request)
        {
            Contrahent result = target.MapToEntityModel(request);
            return result;
            // TODO: add assertions to method ContrahentServiceTest.MapToEntityModel(ContrahentService, ContrahentRequest)
        }
    }
}
