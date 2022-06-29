using System.Collections.Generic;

namespace EStore.Domains.Entities
{
    /// <summary>
    /// Категория
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Id Категори
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Наименование категории
        /// </summary>
        public string Name { get; set; }
        
        public List<Product> Products { get; set; }= new List<Product>();
    }
}