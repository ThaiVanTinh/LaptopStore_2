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
                Criteria = p => p.ProductId.ToString().Contains(searchString);
                Criteria = p => p.Quantity.ToString().Contains(searchString);
            }
            else
            {
                Criteria = p => true;
            }
        }
    }
}
