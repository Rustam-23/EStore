using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EStore.DataAccess;
using EStore.Services.ProductCQRS.Dtos;
using MediatR;

namespace EStore.Services.CategoryCQRS.Queries
{
    /// <summary>
    /// Получение спецификаций
    /// </summary>
    public class GetAllSpecificationByCategoryQuery : IRequest<IEnumerable<SpecificationDto>>
    {
        public int Id { get; }

        public GetAllSpecificationByCategoryQuery(int id)
        {
            Id = id;
        }

        private class GetAllSpecificationByCategoryQueryHandler : IRequestHandler<GetAllSpecificationByCategoryQuery,
            IEnumerable<SpecificationDto>>
        {
            private readonly EStoreContext _context;

            public GetAllSpecificationByCategoryQueryHandler(EStoreContext context)
            {
                _context = context;
            }

            public async Task<IEnumerable<SpecificationDto>> Handle(
                GetAllSpecificationByCategoryQuery request, CancellationToken cancellationToken)
            {
                //Получить все id продуктов по категории
                //Получить все спецификации по этим товарам
                var productIds = _context.Products
                    .Where(x => x.CategoryId == request.Id)
                    .Select(x => x.Id).ToList();

                var specificationIds = _context.ProductSpecifications
                    .Where(x => productIds.Contains(x.ProductId))
                    .Select(x => x.SpecificationId).Distinct().ToList();

                var specifications = _context.Specifications
                    .Where(x => specificationIds.Contains(x.Id))
                    .Select(x => new SpecificationDto()
                    {
                        Id = x.Id,
                        Name = x.Name,
                        SpecificationType = x.SpecificationType
                    })
                    .ToList();
                return specifications;
            }
        }
    }
}