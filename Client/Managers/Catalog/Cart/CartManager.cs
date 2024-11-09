using LaptopStore.Application.Features.Carts.Queries.GetAll;
using LaptopStore.Client.Infrastructure.Extensions;
using LaptopStore.Shared.Wrapper;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using LaptopStore.Application.Features.Carts.Commands.AddEdit;

namespace LaptopStore.Client.Infrastructure.Managers.Catalog.Cart
{
    public class CartManager : ICartManager
    {
        private readonly HttpClient _httpClient;

        public CartManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult<string>> ExportToExcelAsync(string searchString = "")
        {
            var response = await _httpClient.GetAsync(string.IsNullOrWhiteSpace(searchString)
                ? Routes.CartsEndpoints.Export
                : Routes.CartsEndpoints.ExportFiltered(searchString));
            return await response.ToResult<string>();
        }

        public async Task<IResult<int>> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"{Routes.CartsEndpoints.Delete}/{id}");
            return await response.ToResult<int>();
        }

        public async Task<IResult<List<GetAllCartsResponse>>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync(Routes.CartsEndpoints.GetAll);
            return await response.ToResult<List<GetAllCartsResponse>>();
        }

        public async Task<IResult<int>> SaveAsync(AddEditCartCommand request)
        {
            var response = await _httpClient.PostAsJsonAsync(Routes.CartsEndpoints.Save, request);
            return await response.ToResult<int>();
        }
    }
}