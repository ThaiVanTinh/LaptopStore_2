using LaptopStore.Application.Specifications.Base;
using LaptopStore.Domain.Entities.Catalog;

namespace LaptopStore.Application.Specifications.Catalog
{
    public class CartFilterSpecification : HeroSpecification<Cart>
    {
        public CartFilterSpecification(string searchString)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
<<<<<<< HEAD
                Criteria = p => p.TotalPrice.ToString().Contains(searchString);
                Criteria = p => p.PaymentStatus.Contains(searchString);
=======
                Criteria = p => p.ProductId.ToString().Contains(searchString);
                Criteria = p => p.Quantity.ToString().Contains(searchString);
>>>>>>> 9d7f1a9 (cart)
            }
            else
            {
                Criteria = p => true;
            }
        }
    }
}
