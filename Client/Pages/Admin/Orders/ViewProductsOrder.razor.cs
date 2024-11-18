using LaptopStore.Application.Features.Orders.Queries.GetById;
using LaptopStore.Client.Infrastructure.Managers.Catalog.Order;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LaptopStore.Client.Pages.Admin.Orders
{
    public partial class ViewProductsOrder
    {
        [CascadingParameter] MudDialogInstance MudDialog { get; set; }
        [Parameter] public int OrderId { get; set; } 

        [Inject] private IOrderManager OrderManager { get; set; } 

        private List<CartItemByIdResponse> OrderItems { get; set; } = new();

        private async Task LoadOrderItemsAsync()
        {
            var response = await OrderManager.GetOrderByIdAsync(OrderId); // Gọi API để lấy thông tin Order
            if (response.Succeeded)
            {
                OrderItems = response.Data.OrderItem;
            }
            else
            {
                _snackBar.Add("Failed to load order items.", Severity.Error);
            }
        }

        private void CloseDialog()
        {
            MudDialog.Close();
        }

        protected override async Task OnInitializedAsync()
        {
            await LoadOrderItemsAsync(); // Tải dữ liệu khi component khởi tạo
        }
    }
}
