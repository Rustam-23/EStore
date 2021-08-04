using System.Collections.Generic;
using EStore.Domains.Entities;

namespace EStore.Services.ProductCQRS.Dtos
{
    public class SpecificationDto
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public ESpecificationType SpecificationType { get; set; }
        
        public List<ProductSpecification> ProductSpecifications { get; set; }= new List<ProductSpecification>();
    }
   }