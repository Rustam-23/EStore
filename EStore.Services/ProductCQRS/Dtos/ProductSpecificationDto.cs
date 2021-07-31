namespace EStore.Services.ProductCQRS.Dtos
{
    public class ProductSpecificationDto
    {
        public int ProductId { get; set; }

        public string ProductSpecificationName { get; set; }

        public int SpecificationId { get; set; }

        public string SpecString { get; set; }

        public decimal? SpecDecimal { get; set; }

        public bool? SpecBoolean { get; set; }
    }
}