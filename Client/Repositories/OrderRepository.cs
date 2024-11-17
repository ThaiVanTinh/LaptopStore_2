using LaptopStore.Application.Interfaces.Repositories;
using LaptopStore.Client.Interfaces.Repositories;
using LaptopStore.Domain.Entities.Catalog;

namespace LaptopStore.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IRepositoryAsync<Order, int> _repository;

        public OrderRepository(IRepositoryAsync<Order, int> repository)
        {
            _repository = repository;
        }
    }
}