using LaptopStore.Domain.Contracts;

namespace LaptopStore.Domain.Entities.Catalog
{
    public class Cart : AuditableEntity<int>
    {
        public int ProductId { get; set; }
        public Product Product { get; set; } = new Product();
        public int Quantity { get; set; }
    }
}