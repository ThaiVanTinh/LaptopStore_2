using LaptopStore.Application.Specifications.Base;
using LaptopStore.Domain.Entities.Catalog;
using System.Linq;

namespace LaptopStore.Application.Specifications.Catalog
{
    public class BrandFilterSpecification : HeroSpecification<Brand>
    {
        public BrandFilterSpecification(string searchString)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                Criteria = p => p.Name.Contains(searchString) ||
                                (p.ProductLines != null && p.ProductLines.Any(line => line.LineName.Contains(searchString)));
            }
            else
            {
                Criteria = p => true;
            }
        }

    }
}
