using LaptopStore.Domain.Contracts;

namespace LaptopStore.Domain.Entities.Catalog
{
    public class Cart : AuditableEntity<int>
    {
        public int TotalPrice { get; set; }
        public string PaymentStatus { get; set; }
    }
}