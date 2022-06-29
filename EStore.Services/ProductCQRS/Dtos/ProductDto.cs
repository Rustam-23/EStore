using System.Collections.Generic;
using EStore.Domains.Entities;

namespace EStore.Services.ProductCQRS.Dtos
{
    /// <summary>
    /// Товар
    /// </summary>
    public class ProductDto
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Нименование
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Категория
        /// </summary>
        public string CategoryName { get; set; }
        
        /// <summary>
        /// Бренд
        /// </summary>
        public string BrandName { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }
        
        /// <summary>
        /// Изображение
        /// </summary>
        public string ImagePath { get; set; }
        
        /// <summary>
        /// Рейтинг
        /// </summary>
        public int Rating { get; set; }

        public List<ProductSpecificationDto> ProductSpecifications { get; set; }
    }
}