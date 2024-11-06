namespace LaptopStore.Application.Features.Products.Queries.GetAllPaged
{
    public class GetAllPagedProductsResponse
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
<<<<<<< HEAD
=======
        public string ImageDataURL { get; set; }
>>>>>>> de5fa1f (Home page)
    }
}