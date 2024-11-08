namespace LaptopStore.Application.Features.Products.Queries.GetProductById
{
    public class GetProductByIdResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
        public string Barcode { get; set; }
        public string Brand { get; set; }
        public string ImageDataURL { get; set; }
    }
}