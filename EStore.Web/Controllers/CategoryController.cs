using System.Threading.Tasks;
using EStore.Services.CategoryCQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var categories = await _mediator.Send(new GetAllCategoriesQuery());
            return Ok(categories);
        }
        
        [HttpGet("id")]
        public async Task<IActionResult> GetAllProductsByCategoryId([FromQuery]int id)
        {
            var products = await _mediator.Send(new GetAllProductsByCategoryIdQuery(id));
            return Ok(products);
        }
        
    }
}