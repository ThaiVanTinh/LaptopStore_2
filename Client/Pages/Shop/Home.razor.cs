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
using System.Timers; // Add this line
using LaptopStore.Application.Features.Products.Commands.AddEdit;
using LaptopStore.Client.Infrastructure.Managers.Catalog.Product;
using LaptopStore.Shared.Constants.Permission;
using Microsoft.AspNetCore.Authorization;
using LaptopStore.Client.Pages.Admin.Products;

namespace LaptopStore.Client.Pages.Shop
{
    public partial class Home : IDisposable // Implement IDisposable to manage resources
    {
        [Inject] private IProductManager ProductManager { get; set; }
        [CascadingParameter] private HubConnection HubConnection { get; set; }

        private IEnumerable<GetAllPagedProductsResponse> _pagedData;
        private MudTable<GetAllPagedProductsResponse> _table;
        [Parameter] public AddEditProductCommand ProductIMG { get; set; } = new();

        private bool isFilterPanelVisible = false;
        private int _totalItems;
        private int _currentPage;
        private string _searchString = "";
        private bool _loaded;
        private IEnumerable<GetAllPagedProductsResponse> _featuredProducts;
        private IEnumerable<GetAllPagedProductsResponse> _RatedProducts;

        protected override async Task OnInitializedAsync()
        {
            _loaded = false;
            await LoadData(0, 10, new TableState()); // Example page size of 10
            ApplyFilters(); // Call ApplyFilters to initialize filtered lists
            _loaded = true;

            // Initialize and start the timer for automatic rotation
            bannerTimer = new Timer(3000);
            bannerTimer.Elapsed += (s, e) => InvokeAsync(ShowNextImage);
            bannerTimer.Start();
        }

        private void ToggleFilterPanel()
        {
            isFilterPanelVisible = !isFilterPanelVisible;
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

        private async Task LoadData(int pageNumber, int pageSize, TableState state)
        {
            var request = new GetAllPagedProductsRequest
            {
                PageNumber = pageNumber + 1, // Convert to 1-based index if necessary
                PageSize = pageSize,
                SearchString = _searchString
            };
            var response = await ProductManager.GetProductsAsync(request);
            if (response.Succeeded)
            {
                _pagedData = response.Data;
                _totalItems = response.TotalCount;
            }
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

        private async Task OnSearch(string text)
        {
            _searchString = text;
            await LoadData(0, 10, new TableState());
            ApplyFilters(); // Update filters based on new search data
            await _table.ReloadServerData();
        }

        // Define filter classes for Brand and Description
        private class BrandFilter
        {
            public string Name { get; set; }
            public bool IsSelected { get; set; }
        }

        private class DescriptionFilter
        {
            public string Name { get; set; }
            public bool IsSelected { get; set; }
        }

        // Initialize filter options for brands and descriptions
        private List<BrandFilter> _brands = new List<BrandFilter>
        {
            new BrandFilter { Name = "Apple" },
            new BrandFilter { Name = "Lenovo" },
            new BrandFilter { Name = "Asus" },
            new BrandFilter { Name = "MSI" },
            new BrandFilter { Name = "HP" },
            new BrandFilter { Name = "Acer" },
            new BrandFilter { Name = "Samsung" },
            new BrandFilter { Name = "MSI" },
        };

        private List<DescriptionFilter> _descriptions = new List<DescriptionFilter>
        {
            new DescriptionFilter { Name = "Gaming" },
            new DescriptionFilter { Name = "Office" },
            new DescriptionFilter { Name = "Ultrabook" }
        };

        private string SelectedPriceRange = "all";
        private int CustomPriceRangeStart;
        private int CustomPriceRangeEnd;
        private string SelectedRateRange = "all";

        // Filter the product data based on selected filters
        private void ApplyFilters()
        {
            if (_pagedData == null) return;

            var selectedBrands = _brands.Where(b => b.IsSelected).Select(b => b.Name).ToList();
            var selectedDescriptions = _descriptions.Where(d => d.IsSelected).Select(d => d.Name).ToList();

            _featuredProducts = _pagedData.Where(p =>
                (selectedBrands.Count == 0 || selectedBrands.Contains(p.Brand)) &&
                (selectedDescriptions.Count == 0 || selectedDescriptions.Contains(p.Description)) &&
                (SelectedRateRange == "all" || (SelectedRateRange == "4andAbove" && p.Rate == 4) ||
                 (SelectedRateRange == "3andAbove" && p.Rate == 3) ||
                 (SelectedRateRange == "2andAbove" && p.Rate == 2) ||
                 (SelectedRateRange == "1andAbove" && p.Rate == 1))
            ).ToList();

            _RatedProducts = _pagedData.Where(p => p.Rate >= 4).ToList();
        }

        // List of banner images
        private List<string> bannerImages = new List<string>
        {
            "/images/banner/1.png",
            "/images/banner/2.png",
            "/images/banner/3.png",
            "/images/banner/4.png",
            "/images/banner/5.png"
        };

        private int currentImageIndex = 0;
        private int secondImageIndex => (currentImageIndex + 1) % bannerImages.Count; // Lấy chỉ số ảnh thứ hai
        private Timer bannerTimer;

        private void ShowNextImage()
        {
            currentImageIndex = (currentImageIndex + 1) % bannerImages.Count;
            StateHasChanged();
        }

        private void ShowPreviousImage()
        {
            currentImageIndex = (currentImageIndex - 1 + bannerImages.Count) % bannerImages.Count;
            StateHasChanged();
        }

        public void Dispose()
        {
            bannerTimer?.Dispose();
        }
    }
}
