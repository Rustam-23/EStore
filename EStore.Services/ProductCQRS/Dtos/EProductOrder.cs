namespace EStore.Services.ProductCQRS.Dtos
{
    /// <summary>
    /// Сортировка
    /// </summary>
    public enum EProductOrder
    {
        PriceAsc = 1, // сортировка по возрастанию цены
        PriceDesc,    // сортировка по убыванию цены
        RatingAsc,    // сортировка по возрастанию рейтинга
        RatingDesc    // сортировка по убыванию рейтинга
    }
}