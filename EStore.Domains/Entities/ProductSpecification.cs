namespace EStore.Domains.Entities
{
    /// <summary>
    /// Спецификация продукта
    /// </summary>
    public class ProductSpecification
    {
        /// <summary>
        /// Id продукта
        /// </summary>
        public int ProductId { get; set; }
        
        /// <summary>
        /// Прродукт
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// Id Спецификациb
        /// </summary>
        public int SpecificationId { get; set; }
        public Specification Specification { get; set; }

        public string SpecString { get; set; }

        public decimal? SpecDecimal { get; set; }

        public bool? SpecBoolean { get; set; }
        
        
    }
}