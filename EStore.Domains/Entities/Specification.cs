using System.Collections.Generic;

namespace EStore.Domains.Entities
{
    public class Specification
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public ESpecificationType SpecificationType { get; set; }
        
        public List<ProductSpecification> ProductSpecifications { get; set; }= new List<ProductSpecification>();
    }

    public enum ESpecificationType
    {
        SpecString = 1,
        SpecDecimal,
        SpecBoolean,
    }
}