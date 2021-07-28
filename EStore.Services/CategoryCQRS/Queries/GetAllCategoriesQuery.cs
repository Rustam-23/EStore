using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EStore.DataAccess;
using EStore.Services.CategoryCQRS.Dtos;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EStore.Services.CategoryCQRS.Queries
{
    public class GetAllCategoriesQuery : IRequest<IEnumerable<CategoryDto>>
    {
        private class GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQuery, IEnumerable<CategoryDto>>
        {
            private readonly EStoreContext _context;

            public GetAllCategoriesQueryHandler(EStoreContext context)
            {
                _context = context;
            }
            
            public async Task<IEnumerable<CategoryDto>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
            {
                var categories = await _context.Categories
                    .Select(x=>new CategoryDto
                    {
                        Id = x.Id,
                        Name = x.Name
                    })
                    .ToListAsync(cancellationToken: cancellationToken);
                return categories;
            }
        }
    }
}