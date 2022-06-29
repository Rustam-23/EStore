using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EStore.DataAccess;
using EStore.Services.ProductCQRS.Dtos;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EStore.Services.ProductCQRS.Queries
{
    public class GetProductByIdQuery : IRequest<IEnumerable<ProductDto>>
    {
        public int Id { get; set; }

        public GetProductByIdQuery(int id)
        {
            Id = id;
        }
        private class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, IEnumerable<ProductDto>>
        {
            private readonly EStoreContext _context;

            public GetProductByIdQueryHandler(EStoreContext context)
            {
                _context = context;
            }

            public async Task<IEnumerable<ProductDto>> Handle(GetProductByIdQuery request,
                CancellationToken cancellationToken)
            {
                var product = await _context.Products
                    .Where(x => x.Id == request.Id)
                    .Select(x =>
                        new ProductDto
                        {
                            Id = x.Id
                        }).ToListAsync(cancellationToken);

                return product;
            }
        }
    }
}