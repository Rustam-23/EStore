using System.Collections.Generic;

namespace EStore.Domains.Entities
{
    /// <summary>
    /// Товар
    /// </summary>
    public class Product
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
        /// Id
        /// </summary>
        public int CategoryId { get; set; }
        
        /// <summary>
        /// Id
        /// </summary>
        public Category Category { get; set; }
        
        /// <summary>
        /// Id
        /// </summary>
        public int BrandId { get; set; }

        /// <summary>
        /// Бренд
        /// </summary>
        public Brand Brand { get; set; }

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
        
        public List<ProductSpecification> ProductSpecifications { get; set; }= new List<ProductSpecification>();
    }
}