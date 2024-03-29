﻿using System.Collections.Generic;

namespace EStore.Domains.Entities
{
    public class Product
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        
        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        public decimal Price { get; set; }
        
        public string ImagePath { get; set; }
        
        public int Rating { get; set; }
        
        public List<ProductSpecification> ProductSpecifications { get; set; }= new List<ProductSpecification>();
    }
}