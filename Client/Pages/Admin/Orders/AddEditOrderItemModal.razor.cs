using LaptopStore.Application.Features.OrderItems.Commands.AddEdit;
using LaptopStore.Client.Infrastructure.Managers.Catalog.OrderItem;
using LaptopStore.Client.Infrastructure.Managers.Catalog.Product;
using LaptopStore.Client.Infrastructure.Managers.Catalog.Order;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.IO;
using System.Threading.Tasks;
using Blazored.FluentValidation;
using LaptopStore.Application.Requests;
using LaptopStore.Shared.Constants.Application;
using Microsoft.AspNetCore.SignalR.Client;
using LaptopStore.Client.Extensions;
using Microsoft.AspNetCore.Components.Forms;
using System.Linq;
using Org.BouncyCastle.Asn1.Ocsp;

namespace LaptopStore.Client.Pages.Admin.Orders
{
    public partial class AddEditOrderItemModal
    {
        [Inject] private IOrderItemManager OrderItemManager { get; set; }
        [Inject] private IOrderManager OrderManager { get; set; }
        [Inject] private IProductManager ProductManager { get; set; }
        [Parameter] public int OrderId { get; set; }

        [Parameter] public AddEditOrderItemCommand AddEditOrderItemModel { get; set; } = new();
        [CascadingParameter] private MudDialogInstance MudDialog { get; set; }
        [CascadingParameter] private HubConnection HubConnection { get; set; }

        private FluentValidationValidator _fluentValidationValidator;
        private bool Validated => _fluentValidationValidator.Validate(options => { options.IncludeAllRuleSets(); });

        protected override async Task OnInitializedAsync()
        {
            HubConnection = HubConnection.TryInitialize(_navigationManager);
            if (HubConnection.State == HubConnectionState.Disconnected)
            {
                await HubConnection.StartAsync();
            }

            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            if (OrderId != 0)
            {
                var orderItemResponse = await OrderManager.GetOrderByIdAsync(OrderId);
                if (orderItemResponse.Succeeded && orderItemResponse.Data.OrderItem != null && orderItemResponse.Data.OrderItem.Any())
                {
                    var orderItem = orderItemResponse.Data.OrderItem.First();
                    AddEditOrderItemModel = new AddEditOrderItemCommand
                    {
                        Id = orderItem.Id,
                        OrderId = orderItem.OrderId,
                        ProductId = orderItem.ProductId,
                        ProductName = orderItem.ProductName,
                        ProductPrice = orderItem.ProductPrice,
                        Quantity = orderItem.Quantity,
                    };
                    await LoadImageAsync();
                }
                else
                {
                    AddEditOrderItemModel = new AddEditOrderItemCommand { OrderId = OrderId };
                }
            }
        }

        private async Task LoadImageAsync()
        {
            var imageResponse = await ProductManager.GetProductImageAsync(AddEditOrderItemModel.ProductId);
            if (imageResponse.Succeeded)
            {
                AddEditOrderItemModel.ProductImage = imageResponse.Data;
            }
        }
        private async Task SaveAsync()
        {
            // Fetch the product details based on ProductId
            var productResponse = await ProductManager.GetProductByIdAsync(AddEditOrderItemModel.ProductId);
            if (productResponse.Succeeded)
            {
                // Set the product name and price
                AddEditOrderItemModel.ProductName = productResponse.Data.Name;
                AddEditOrderItemModel.ProductPrice = productResponse.Data.Price;
            }
            else
            {
                _snackBar.Add("Product not found.", Severity.Error);
                return;
            }

            // Proceed with saving the order item
            var response = await OrderItemManager.SaveAsync(AddEditOrderItemModel);
            if (response.Succeeded)
            {
                _snackBar.Add(response.Messages[0], Severity.Success);
                MudDialog.Close();
                await HubConnection.SendAsync(ApplicationConstants.SignalR.SendUpdateDashboard);
            }
            else
            {
                foreach (var message in response.Messages)
                {
                    _snackBar.Add(message, Severity.Error);
                }
            }
        }



        public void Cancel()
        {
            MudDialog.Cancel();
        }

        private async Task DeleteOrderItem()
        {
            var response = await OrderItemManager.DeleteAsync(AddEditOrderItemModel.Id);
            if (response.Succeeded)
            {
                _snackBar.Add("Product deleted successfully", Severity.Success);
                MudDialog.Close();
                await HubConnection.SendAsync(ApplicationConstants.SignalR.SendUpdateDashboard);
            }
            else
            {
                foreach (var message in response.Messages)
                {
                    _snackBar.Add(message, Severity.Error);
                }
            }
        }
    }
}
