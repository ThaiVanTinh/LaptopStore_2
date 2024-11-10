using LaptopStore.Application.Features.Products.Queries.GetProductById;
using LaptopStore.Client.Extensions;
using LaptopStore.Client.Infrastructure.Managers.Catalog.Product;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using MudBlazor;
using System;
using System.Threading.Tasks;

namespace LaptopStore.Client.Pages.Shop
{
    public partial class ProductDetail : ComponentBase
    {
        [Inject] private IProductManager ProductManager { get; set; }
        [Inject] private NavigationManager NavigationManager { get; set; }
        [Inject] private ISnackbar Snackbar { get; set; }

        [Parameter] public int productId { get; set; }
        public GetProductByIdResponse Product { get; set; } = new();
        [CascadingParameter] private HubConnection HubConnection { get; set; }

        protected override async Task OnInitializedAsync()
        {
            if (productId <= 0) // Check for a valid product ID
            {
                Snackbar.Add("Product ID không hợp lệ.", Severity.Error);
                NavigationManager.NavigateTo("/not-found");
                return;
            }

            try
            {
                Console.WriteLine($"Product ID: {productId}");  // Log the product ID to verify
                await LoadProductDetails();
            }
            catch (Exception ex)
            {
                Snackbar.Add($"Đã xảy ra lỗi khi khởi tạo: {ex.Message}", Severity.Error);
            }
        }

        private async Task LoadProductDetails()
        {
            var result = await ProductManager.GetProductByIdAsync(productId);
            if (result.Succeeded && result.Data != null)
            {
                // Map product data
                Product = result.Data;
                Snackbar.Add("Dữ liệu sản phẩm đã tải thành công!", Severity.Success);
                StateHasChanged();
            }
            else
            {
                // Handle errors and add logging
                Snackbar.Add("Không thể tải dữ liệu sản phẩm hoặc sản phẩm không tồn tại.", Severity.Error);
                NavigationManager.NavigateTo("/not-found");
            }
        }

        private async Task LoadImageAsync()
        {
            try
            {
                var data = await ProductManager.GetProductImageAsync(productId);
                if (data.Succeeded && !string.IsNullOrEmpty(data.Data))
                {
                    Product.ImageDataURL = data.Data;
                }
            }
            catch (NotImplementedException ex)
            {
                Snackbar.Add($"Chức năng tải ảnh chưa được triển khai: {ex.Message}", Severity.Error);
            }
            catch (Exception ex)
            {
                Snackbar.Add($"Đã xảy ra lỗi khi tải ảnh: {ex.Message}", Severity.Error);
            }
        }
    }
}
