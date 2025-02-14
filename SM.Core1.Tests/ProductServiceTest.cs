using System.Threading.Tasks;
using SM.Core.Models.Responses;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SM.Core.Services;

namespace SM.Core.Services.Tests
{
    [TestClass]
    [PexClass(typeof(ProductService))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ProductServiceTest
    {

        [PexMethod]
        public Task<ProductResponse> GetAsync(
            [PexAssumeUnderTest] ProductService target,
            Guid id,
            Guid userId
        )
        {
            Task<ProductResponse> result = target.GetAsync(id, userId);
            return result;
            // TODO: add assertions to method ProductServiceTest.GetAsync(ProductService, Guid, Guid)
        }
    }
}
