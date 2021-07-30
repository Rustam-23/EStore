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
        [HttpGet]
        public async Task<IActionResult> GetAllProductsSortByPrice(decimal minPrice, EProductOrder productOrder, decimal maxPrice = decimal.MaxValue)
        {
            var products = await _mediator.Send(new GetAllProductQuery(minPrice, maxPrice, productOrder));
            return Ok(products);
        }
    }
}