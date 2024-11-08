using LaptopStore.Application.Features.Products.Queries.GetProductById;
using LaptopStore.Application.Requests;
using LaptopStore.Client.Extensions;
using LaptopStore.Shared.Constants.Application;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.SignalR.Client;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Blazored.FluentValidation;
using LaptopStore.Client.Infrastructure.Managers.Catalog.Brand;
using LaptopStore.Client.Infrastructure.Managers.Catalog.Product;
using LaptopStore.Client.Pages.Admin.Products;

namespace LaptopStore.Client.Pages.Shop
{
    public partial class ProductDetail
    {
        [Inject] private IProductManager ProductManager { get; set; }
        [Inject] private IBrandManager BrandManager { get; set; }

        [Parameter] public GetProductByIdResponse Product { get; set; } = new();
        [CascadingParameter] private HubConnection HubConnection { get; set; }
        [CascadingParameter] private MudDialogInstance MudDialog { get; set; }

        private FluentValidationValidator _fluentValidationValidator;
        private bool Validated => _fluentValidationValidator.Validate(options => { options.IncludeAllRuleSets(); });

        public void Cancel()
        {
            MudDialog.Cancel();
        }

        protected override async Task OnInitializedAsync()
        {
            await LoadDataAsync();
            HubConnection = HubConnection.TryInitialize(_navigationManager);
            if (HubConnection.State == HubConnectionState.Disconnected)
            {
                await HubConnection.StartAsync();
            }
        }

        private async Task LoadDataAsync()
        {
            await LoadImageAsync();
        }
 
        private async Task LoadImageAsync()
        {
            var data = await ProductManager.GetProductImageAsync(Product.Id);
            if (data.Succeeded)
            {
                var imageData = data.Data;
                if (!string.IsNullOrEmpty(imageData))
                {
                    Product.ImageDataURL = imageData;
                }
            }
        }  
    }
}