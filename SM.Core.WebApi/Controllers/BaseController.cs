using Microsoft.AspNetCore.Mvc;
using SM.Core.Models.Responses;
using SM.Core.Services.Interfaces;

namespace SM.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class BaseController<TRequest, TResponse> : ControllerBase
        where TRequest : class
        where TResponse : BaseResponse
    {
        protected readonly IBaseService<TRequest, TResponse> Service;

        protected BaseController(IBaseService<TRequest, TResponse> service)
        {
            Service = service;
        }

        [HttpGet]
        public virtual async Task<ActionResult<IEnumerable<TResponse>>> GetAll()
        {
            var result = await Service.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public virtual async Task<ActionResult<TResponse>> Get(Guid id)
        {
            var result = await Service.GetAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        public virtual async Task<ActionResult> Create([FromBody] TRequest request)
        {
            var id = await Service.AddAsync(request);
            return Ok(id);
        }

        [HttpPut("{id}")]
        public virtual async Task<ActionResult> Update(Guid id, [FromBody] TRequest request)
        {
            try
            {
                await Service.UpdateAsync(request, id);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public virtual async Task<ActionResult> Delete(Guid id)
        {
            try
            {
                await Service.RemoveAsync(id);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }
    }
}
