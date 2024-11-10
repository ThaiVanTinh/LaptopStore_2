namespace LaptopStore.Domain.Entities.Catalog
{
    public class ProductLine
    {
        public int Id { get; set; }
        public string LineName { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
    }
}
