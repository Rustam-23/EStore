namespace EStore.Domains.Entities
{
    public class ProductSpecification
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int SpecificationId { get; set; }
        public Specification Specification { get; set; }

        public string SpecString { get; set; }

        public decimal? SpecDecimal { get; set; }

        public bool? SpecBoolean { get; set; }
        
        
    }
}