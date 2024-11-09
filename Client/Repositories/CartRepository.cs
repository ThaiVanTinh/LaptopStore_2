using LaptopStore.Application.Interfaces.Repositories;
using LaptopStore.Domain.Entities.Catalog;

namespace LaptopStore.Infrastructure.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly IRepositoryAsync<Cart, int> _repository;

        public CartRepository(IRepositoryAsync<Cart, int> repository)
        {
            _repository = repository;
        }
    }
}