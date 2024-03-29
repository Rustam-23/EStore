﻿using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EStore.DataAccess;
using EStore.Services.ProductCQRS.Dtos;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EStore.Services.ProductCQRS.Queries
{
    public class GetAllProductQuery : IRequest<IEnumerable<ProductDto>>
    {
        public int CategoryId { get; set; }
        public decimal MaxPrice { get; set; }
        public EProductOrder ProductOrder { get; set; }
        public decimal MinPrice { get; set; }
        public GetAllProductQuery(int categoryId, decimal minPrice, decimal maxPrice, EProductOrder productOrder)
        {
            CategoryId = categoryId;
            MaxPrice = maxPrice;
            ProductOrder = productOrder;
            MinPrice = minPrice;
        }
        
        private class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, IEnumerable<ProductDto>>
        {
            private readonly EStoreContext _context;

            public GetAllProductQueryHandler(EStoreContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<ProductDto>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
            {
                var products = await _context.Products
                    .Include(x=> x.ProductSpecifications)
                    .ThenInclude(x=> x.Specification)
                    .Where(x=> x.CategoryId == request.CategoryId)
                    .Where(x=> x.Price < request.MaxPrice && x.Price > request.MinPrice)
                    .Select(x =>
                        new ProductDto
                        {
                            Id = x.Id,
                            CategoryName = x.Category.Name,
                            Name = x.Name,
                            BrandName = x.Brand.Name,
                            Price = x.Price,
                            Rating = x.Rating,
                            ImagePath = x.ImagePath,
                            ProductSpecifications = x.ProductSpecifications
                                .Select(p=> new ProductSpecificationDto
                                {
                                    ProductId = p.ProductId,
                                    SpecificationId = p.SpecificationId,
                                    SpecString = p.SpecString,
                                    SpecDecimal = p.SpecDecimal,
                                    SpecBoolean = p.SpecBoolean,
                                    ProductSpecificationName = p.Specification.Name
                                }).ToList()
                        })                    
                    .ToListAsync(cancellationToken);

                return request.ProductOrder switch
                {
                    EProductOrder.PriceAsc => products.OrderBy(x => x.Price).ToList(),
                    EProductOrder.PriceDesc => products.OrderByDescending(x => x.Price).ToList(),
                    EProductOrder.RatingAsc => products.OrderBy(x => x.Rating).ToList(),
                    EProductOrder.RatingDesc => products.OrderByDescending(x => x.Rating).ToList(),
                    _ => products
                };
            }
        }
    }
}