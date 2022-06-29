namespace EStore.Services.CategoryCQRS.Dtos
{
    /// <summary>
    /// Категория
    /// </summary>
    public class CategoryDto 
    {
        /// <summary>
        /// Id Категори
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }
    }
}