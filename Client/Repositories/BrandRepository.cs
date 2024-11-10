using LaptopStore.Application.Interfaces.Repositories;
using LaptopStore.Domain.Entities.Catalog;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LaptopStore.Infrastructure.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly IRepositoryAsync<Brand, int> _repository;

        public BrandRepository(IRepositoryAsync<Brand, int> repository)
        {
            _repository = repository;
        }

        public async Task<Brand> GetByIdAsync(int id)
        {
            return await _repository.Entities
                .Include(b => b.ProductLines) // Include ProductLines to load them from the database
                .FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<List<Brand>> GetAllAsync()
        {
            return await _repository.Entities
                .Include(b => b.ProductLines) // Include ProductLines for all Brands
                .ToListAsync();
        }

        public async Task<int> InsertAsync(Brand brand)
        {
            await _repository.AddAsync(brand);
            return brand.Id;
        }

        public async Task<int> UpdateAsync(Brand brand)
        {
            await _repository.UpdateAsync(brand);
            return brand.Id;
        }

        public async Task<int> DeleteAsync(int id)
        {
            var brand = await _repository.Entities.FirstOrDefaultAsync(b => b.Id == id);
            if (brand != null)
            {
                await _repository.DeleteAsync(brand);
                return id;
            }
            return 0;
        }
    }
}
