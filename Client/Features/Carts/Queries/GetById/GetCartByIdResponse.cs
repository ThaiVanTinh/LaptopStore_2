<<<<<<< HEAD
﻿using LaptopStore.Application.Features.Products.Queries.GetAllPaged;
=======
﻿using LaptopStore.Domain.Entities.Catalog;
>>>>>>> 9d7f1a9 (cart)

namespace LaptopStore.Application.Features.Carts.Queries.GetById
{
    public class GetCartByIdResponse
    {
<<<<<<< HEAD
        public int UserID { get; set; }
        public int ProductID { get; set; }
        public GetAllPagedProductsResponse AllProduct { get; set; }
        public int TotalPrice { get; set; }
        public string PaymentStatus { get; set; }
        public int Id { get; set; }
=======
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = new Product();
        public int Quantity { get; set; }
>>>>>>> 9d7f1a9 (cart)
    }
}