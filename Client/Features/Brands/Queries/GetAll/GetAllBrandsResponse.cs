using System.Collections.Generic;

namespace LaptopStore.Application.Features.Brands.Queries.GetAll
{
    public class GetAllBrandsResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> ProductLines { get; set; }  // Ensure this exists
    }
}