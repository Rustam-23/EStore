using System;
using System.Threading.Tasks;
using EStore.Services.CategoryCQRS.Queries;
using EStore.Services.ProductCQRS.Dtos;
using EStore.Services.ProductCQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("getAllProductsSortByPrice")]
        public async Task<IActionResult> GetAllProductsSortByPrice(int categoryId, decimal minPrice, EProductOrder productOrder, decimal maxPrice = decimal.MaxValue)
        {
            var products = await _mediator.Send(new GetAllProductQuery(categoryId, minPrice, maxPrice, productOrder));
            return Ok(products);
        }
    }
}