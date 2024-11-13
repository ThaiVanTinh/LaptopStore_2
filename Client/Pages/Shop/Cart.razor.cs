using LaptopStore.Client.Infrastructure.Managers.Catalog.Product;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace LaptopStore.Client.Pages.Shop
{
    public partial class Cart
    {
        [Inject] private IProductManager ProductManager { get; set; }
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
            await JS.InvokeVoidAsync("localStorage.setItem", "cartItems", JsonSerializer.Serialize(cartItems));
        }
        private decimal GetTotalPrice()
        {
            return cartItems.Sum(item => item.ProductPrice * item.Quantity);
        }

        private void Checkout()
        {
            // Điều hướng đến trang /order
            NavigationManager.NavigateTo("/order");
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

        public class CartItem
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public decimal ProductPrice { get; set; }
            public string ProductImage { get; set; } = string.Empty;
            public int Quantity { get; set; }
        }
    }
}
