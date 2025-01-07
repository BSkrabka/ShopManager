using Azure;
using Microsoft.AspNetCore.Mvc;
using SM.Api.Controllers;
using SM.Core.Models.Requests;
using SM.Core.Models.Responses;
using SM.Core.Services.Interfaces;

namespace SM.Core.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : BaseController<ProductRequest, ProductResponse>
    {
        private IProductService _productService { get; set; }

        public ProductController(IProductService productService) : base(productService)
        {
            _productService = productService;
        }

        [HttpGet("{id}")]
        public override async Task<ActionResult<ProductResponse>> Get(Guid id)
        {
            var result = await _productService.GetAsync(id, GetUserId());
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        private Guid GetUserId()
        {
            return Guid.Parse("440FD555-A411-447E-4EE2-08DD22BB75E5");
        }
    }
}
