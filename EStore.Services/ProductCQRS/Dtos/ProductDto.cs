namespace EStore.Services.ProductCQRS.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string CategoryName { get; set; }
        
        public string BrandName { get; set; }

        public decimal Price { get; set; }
        
        public string ImagePath { get; set; }
        
        public int Rating { get; set; }
    }
}