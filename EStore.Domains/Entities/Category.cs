using System.Collections.Generic;

namespace EStore.Domains.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public List<Product> Products { get; set; }= new List<Product>();
    }
}