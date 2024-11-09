using LaptopStore.Domain.Entities.Catalog;

namespace LaptopStore.Application.Features.Carts.Queries.GetById
{
    public class GetCartByIdResponse
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = new Product();
        public int Quantity { get; set; }
    }
}