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
            try
            {
                await LoadProductDetails();
                HubConnection = HubConnection.TryInitialize(NavigationManager);
                if (HubConnection.State == HubConnectionState.Disconnected)
                {
                    await HubConnection.StartAsync();
                }
            }
            catch (Exception ex)
            {
                Snackbar.Add($"Đã xảy ra lỗi khi khởi tạo: {ex.Message}", Severity.Error);
            }
        }

        private async Task LoadProductDetails()
        {
            try
            {
                var result = await ProductManager.GetProductByIdAsync(productId);
                if (result.Succeeded && result.Data != null)
                {
                    Product = result.Data;
                    Snackbar.Add("Dữ liệu sản phẩm đã tải thành công!", Severity.Success);
                    await LoadImageAsync(); // Gọi để tải ảnh nếu cần thiết
                    StateHasChanged(); // Cập nhật giao diện sau khi có dữ liệu
                }
                else
                {
                    Snackbar.Add("Không thể tải dữ liệu sản phẩm hoặc sản phẩm không tồn tại.", Severity.Error);
                    NavigationManager.NavigateTo("/not-found");
                }
            }
            catch (NotImplementedException ex)
            {
                Snackbar.Add($"Chức năng chưa được triển khai: {ex.Message}", Severity.Error);
            }
            catch (Exception ex)
            {
                Snackbar.Add($"Đã xảy ra lỗi: {ex.Message}", Severity.Error);
            }
        }

        private async Task LoadImageAsync()
        {
            try
            {
                var data = await ProductManager.GetProductImageAsync(productId);
                if (data.Succeeded)
                {
                    var imageData = data.Data;
                    if (!string.IsNullOrEmpty(imageData))
                    {
                        Product.ImageDataURL = imageData;
                    }
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
