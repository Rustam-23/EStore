using System.Collections.Generic;

namespace EStore.Domains.Entities
{
    /// <summary>
    /// Спецификация
    /// </summary>
    public class Specification
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Наименование спецификации
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Тип спецификации
        /// </summary>
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