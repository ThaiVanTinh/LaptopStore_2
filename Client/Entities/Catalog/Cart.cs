using LaptopStore.Domain.Contracts;

namespace LaptopStore.Domain.Entities.Catalog
{
    public class Cart : AuditableEntity<int>
    {
<<<<<<< HEAD
        public int TotalPrice { get; set; }
        public string PaymentStatus { get; set; }
=======
        public int ProductId { get; set; }
        public Product Product { get; set; } = new Product();
        public int Quantity { get; set; }
>>>>>>> 9d7f1a9 (cart)
    }
}