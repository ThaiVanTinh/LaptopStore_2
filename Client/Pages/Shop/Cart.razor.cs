using AutoMapper;
using LaptopStore.Application.Features.Orders.Commands.AddEdit;
using LaptopStore.Application.Interfaces.Repositories;
using LaptopStore.Application.Interfaces.Services;
using LaptopStore.Application.Requests.Catalog;
using LaptopStore.Client.Extensions;
using LaptopStore.Client.Infrastructure.Managers.Catalog.Order;
using LaptopStore.Client.Infrastructure.Managers.Catalog.Product;
using LaptopStore.Shared.Constants.Application;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace LaptopStore.Client.Pages.Shop
{
    public partial class Cart
    {
        [Inject] private IProductManager ProductManager { get; set; }
        [Inject] private IOrderManager OrderManager { get; set; }
        [Inject] private NavigationManager NavigationManager { get; set; }

        private List<CartItem> cartItems = new();

        protected override async Task OnInitializedAsync()
        {
            var cartJson = await JS.InvokeAsync<string>("localStorage.getItem", "cartItems");
            if (!string.IsNullOrEmpty(cartJson))
            {
                cartItems = JsonSerializer.Deserialize<List<CartItem>>(cartJson);

                // Tải hình ảnh cho từng sản phẩm
                foreach (var item in cartItems)
                {
                    await LoadImageAsync(item);
                }
            }
        }

        private bool IsQuantityLessThanOrEqualToOne(CartItem item) => item.Quantity <= 1;

        private async Task UpdateQuantity(CartItem item, int newQuantity)
        {
            item.Quantity = newQuantity;
            await SaveCartToLocalStorage();
        }

        private async Task RemoveFromCart(int productId)
        {
            cartItems = cartItems.Where(i => i.ProductId != productId).ToList();
            await SaveCartToLocalStorage();
        }

        private async Task SaveCartToLocalStorage()
        {
            await JS.InvokeVoidAsync("localStorage.setItem", "cartItems", System.Text.Json.JsonSerializer.Serialize(cartItems));
        }
        private decimal GetTotalPrice()
        {
            return cartItems.Sum(item => item.ProductPrice * item.Quantity);
        }


        private async Task Checkout()
        {
            //if (cartItems.Any())
            //{         
            //    var state = await _stateProvider.GetAuthenticationStateAsync();
            //    var user = state.User;
            //    var userId = user.GetUserId();


            //    if (string.IsNullOrEmpty(userId))
            //    {
            //        await JS.InvokeVoidAsync("alert", "Bạn phải đăng nhập để đặt hàng!");
            //        return;
            //    }
            //    var order = new Domain.Entities.Catalog.Order
            //    {

            //        UserId = userId,
            //        UserAddress = string.Empty, 
            //        TotalPrice = (int)GetTotalPrice(),
            //        MethodPayment = string.Empty,
            //        StatusOrder = string.Empty, 
            //        IsPayment = false,
            //        OrderItem = cartItems.Select(item => new Domain.Entities.Catalog.CartItem
            //        {
            //            ProductId = item.ProductId,
            //            ProductName = item.ProductName,
            //            ProductPrice = item.ProductPrice,
            //            Quantity = item.Quantity
            //        }).ToList()
            //    };

            //    Console.WriteLine(JsonSerializer.Serialize(order)); // Logging order for debugging
            //    await OrderManager.CreateOrderAsync(order);
            //    await JS.InvokeVoidAsync("alert", "Order placed successfully!");

            //    // Xóa cartItems và cập nhật localStorage
            //    cartItems.Clear();
            //    await SaveCartToLocalStorage();

            //    NavigateToProductDetail();
            //}
            //else
            //{
            //    await JS.InvokeVoidAsync("alert", "Your cart is empty!");
            //}
            NavigateToProductDetail();
        }

        private async Task LoadImageAsync(CartItem item)
        {
            var data = await ProductManager.GetProductImageAsync(item.ProductId);
            if (data.Succeeded)
            {
                var imageData = data.Data;
                if (!string.IsNullOrEmpty(imageData))
                {
                    item.ProductImage = imageData;
                }
            }
        }

        private void NavigateToProductDetail()
        {
            NavigationManager.NavigateTo($"/order");
        }

    }
}
