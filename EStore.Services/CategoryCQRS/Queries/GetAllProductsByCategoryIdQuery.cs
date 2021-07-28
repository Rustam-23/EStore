using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EStore.DataAccess;
using EStore.Services.ProductCQRS.Dtos;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EStore.Services.CategoryCQRS.Queries
{
    public class GetAllProductsByCategoryIdQuery : IRequest<IEnumerable<ProductDto>>
    {
        public int Id { get; }

        public GetAllProductsByCategoryIdQuery(int id)
        {
            Id = id;
        }
        
        private class GetAllProductsByCategoryIdQueryHandler : IRequestHandler<GetAllProductsByCategoryIdQuery, IEnumerable<ProductDto>>
        {
            private readonly EStoreContext _context;

            public GetAllProductsByCategoryIdQueryHandler(EStoreContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<ProductDto>> Handle(GetAllProductsByCategoryIdQuery request, CancellationToken cancellationToken)
            {
                var products = await _context.Products
                    .Where(x => x.CategoryId == request.Id)
                    .Include(x => x.Brand)
                    .Select(x => new ProductDto
                    {
                        Id = x.Id,
                        Name = x.Name,
                        BrandName = x.Brand.Name,
                        Price = x.Price,
                        Rating = x.Rating,
                        ImagePath = x.ImagePath
                    })
                    .ToListAsync(cancellationToken);
                return products;
            }
        }
    }
    
}