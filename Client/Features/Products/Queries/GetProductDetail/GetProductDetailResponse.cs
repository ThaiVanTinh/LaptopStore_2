namespace LaptopStore.Application.Features.Products.Queries.GetProductDetail
{
    public class GetProductsDetailResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
        public bool Featured { get; set; }
        public string Brand { get; set; }
        public int BrandId { get; set; }

        public string ImageDataURL { get; set; }
    }
}