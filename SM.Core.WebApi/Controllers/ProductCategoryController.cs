using Microsoft.AspNetCore.Mvc;
using SM.Api.Controllers;
using SM.Core.Models.Requests;
using SM.Core.Models.Responses;
using SM.Core.Services.Interfaces;

namespace SM.Core.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ProductCategoryController : BaseController<ProductCategoryRequest, ProductCategoryResponse>
    {
        public ProductCategoryController(IProductCategoryService productCategoryService) : base(productCategoryService)
        {
        }
    }
}
