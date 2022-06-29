using System.Collections.Generic;

namespace EStore.Domains.Entities
{
    /// <summary>
    /// Бренд
    /// </summary>
    public class Brand
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Нименование
        /// </summary>
        public string Name { get; set; }
        
        public List<Product> Products { get; set; }= new List<Product>();
    }
}