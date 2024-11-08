using LaptopStore.Application.Features.Products.Queries.GetAllPaged;

namespace LaptopStore.Application.Features.Carts.Queries.GetAll
{
    public class GetAllCartsResponse
    {
        public int UserID { get; set; }
        public int ProductID { get; set; }
        public GetAllPagedProductsResponse AllProduct { get; set; }
        public int TotalPrice { get; set; }
        public string PaymentStatus { get; set; }
        public int Id { get; set; }
    }
}