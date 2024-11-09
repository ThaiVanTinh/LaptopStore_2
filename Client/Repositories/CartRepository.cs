using LaptopStore.Application.Interfaces.Repositories;
<<<<<<< HEAD
using LaptopStore.Client.Infrastructure.Managers.Catalog.Cart;
=======
>>>>>>> 9d7f1a9 (cart)
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