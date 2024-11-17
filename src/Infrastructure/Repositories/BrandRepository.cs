using LaptopStore_2.Application.Interfaces.Repositories;
using LaptopStore_2.Domain.Entities.Catalog;

namespace LaptopStore_2.Infrastructure.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly IRepositoryAsync<Brand, int> _repository;

        public BrandRepository(IRepositoryAsync<Brand, int> repository)
        {
            _repository = repository;
        }
    }
}