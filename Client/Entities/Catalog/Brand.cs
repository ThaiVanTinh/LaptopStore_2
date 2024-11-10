using LaptopStore.Domain.Contracts;
using System.Collections.Generic;

namespace LaptopStore.Domain.Entities.Catalog
{
    public class Brand : AuditableEntity<int>
    {
        public string Name { get; set; }
        public ICollection<ProductLine> ProductLines { get; set; } = new List<ProductLine>();  // Ensure this exists
    }
}