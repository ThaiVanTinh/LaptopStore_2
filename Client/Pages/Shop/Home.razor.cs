using LaptopStore.Application.Features.Products.Queries.GetAllPaged;
using LaptopStore.Application.Requests.Catalog;
using LaptopStore.Client.Extensions;
using LaptopStore.Shared.Constants.Application;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.JSInterop;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using LaptopStore.Application.Features.Products.Commands.AddEdit;
using LaptopStore.Client.Infrastructure.Managers.Catalog.Product;
using LaptopStore.Shared.Constants.Permission;
using Microsoft.AspNetCore.Authorization;
using LaptopStore.Client.Pages.Admin.Products;

namespace LaptopStore.Client.Pages.Shop
{
    public partial class Home
    {
        [Inject] private IProductManager ProductManager { get; set; }

        [CascadingParameter] private HubConnection HubConnection { get; set; }

        private IEnumerable<GetAllPagedProductsResponse> _pagedData;
        private MudTable<GetAllPagedProductsResponse> _table;
        [Parameter] public AddEditProductCommand ProductIMG { get; set; } = new();

        private int _totalItems;
        private int _currentPage;
        private string _searchString = "";
        private bool _loaded;

        protected override async Task OnInitializedAsync()
        {
            _loaded = false;
            await LoadData(0, 10, new TableState()); // Example page size of 10
            _loaded = true;
        }

        private async Task<TableData<GetAllPagedProductsResponse>> ServerReload(TableState state)
        {
            if (!string.IsNullOrWhiteSpace(_searchString))
            {
                state.Page = 0;
            }
            await LoadData(state.Page, state.PageSize, state);
            return new TableData<GetAllPagedProductsResponse> { TotalItems = _totalItems, Items = _pagedData };
        }

        private string DescriptionFilter { get; set; } = string.Empty;

        private async Task LoadData(int pageNumber, int pageSize, TableState state)
        {
            // Existing logic for loading data into _pagedData
            // Example:
            var request = new GetAllPagedProductsRequest { PageSize = pageSize, PageNumber = pageNumber + 1, SearchString = _searchString };
            var response = await ProductManager.GetProductsAsync(request);
            if (response.Succeeded)
            {
                _pagedData = response.Data;
                _totalItems = response.TotalCount;
            }
            _loaded = true;
        }


        private async Task LoadImageAsync()
        {
            var data = await ProductManager.GetProductImageAsync(ProductIMG.Id);
            if (data.Succeeded)
            {
                var imageData = data.Data;
                if (!string.IsNullOrEmpty(imageData))
                {
                    ProductIMG.ImageDataURL = imageData;
                }
            }
        }
        private void OnSearch(string text)
        {
            _searchString = text;
            LoadData(0, 10, new TableState()); // Refresh data with search
        }
    }
}