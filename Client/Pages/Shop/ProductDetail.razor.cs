using LaptopStore.Application.Features.Products.Queries.GetProductById;
using LaptopStore.Client.Infrastructure.Managers.Catalog.Product;
using Microsoft.AspNetCore.Components;
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

        protected override async Task OnParametersSetAsync()
        {
            Console.WriteLine("Đang tải sản phẩm với ID: " + productId); // Ghi log giá trị productId
            if (productId > 0)
            {
                await LoadProduct(productId);
            }
            else
            {
                Snackbar.Add("ID sản phẩm không hợp lệ.", Severity.Error);
                NavigationManager.NavigateTo("/not-found");
            }
        }


        private async Task LoadProduct(int id)
        {
            try
            {
                Console.WriteLine("Bắt đầu gọi ProductManager.GetProductByIdAsync với ID: " + id);

                var result = await ProductManager.GetProductByIdAsync(id);

                // Kiểm tra nếu `result` không thành công hoặc `Data` là null
                if (result == null)
                {
                    Console.WriteLine("Kết quả trả về từ ProductManager.GetProductByIdAsync là null.");
                    Snackbar.Add("Không thể kết nối tới dịch vụ lấy dữ liệu sản phẩm.", Severity.Error);
                    return;
                }

                if (result.Succeeded && result.Data != null)
                {
                    Product = result.Data;
                    Console.WriteLine($"Dữ liệu sản phẩm đã tải thành công: Tên sản phẩm - {Product.Name}, Giá - {Product.Price}");
                    Snackbar.Add("Dữ liệu sản phẩm đã tải thành công!", Severity.Success);

                    // Cập nhật giao diện để hiển thị dữ liệu
                    StateHasChanged();
                }
                else
                {
                    Console.WriteLine("Không thể tải dữ liệu sản phẩm hoặc sản phẩm không tồn tại.");
                    Snackbar.Add("Không thể tải dữ liệu sản phẩm hoặc sản phẩm không tồn tại.", Severity.Error);
                    NavigationManager.NavigateTo("/not-found");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi khi tải dữ liệu sản phẩm: " + ex.Message);
                Snackbar.Add($"Đã xảy ra lỗi khi tải dữ liệu sản phẩm: {ex.Message}", Severity.Error);
            }
        }

    }
}
