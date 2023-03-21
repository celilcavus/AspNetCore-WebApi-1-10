namespace productWebApi.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductCategoryId { get; set; }
    }
}