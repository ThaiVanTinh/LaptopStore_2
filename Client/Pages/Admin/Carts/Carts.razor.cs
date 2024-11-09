using LaptopStore.Application.Features.Carts.Queries.GetAll;
using LaptopStore.Client.Extensions;
using LaptopStore.Shared.Constants.Application;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using LaptopStore.Application.Features.Carts.Commands.AddEdit;
using LaptopStore.Client.Infrastructure.Managers.Catalog.Cart;
using LaptopStore.Shared.Constants.Permission;
using Microsoft.AspNetCore.Authorization;
using Microsoft.JSInterop;

namespace LaptopStore.Client.Pages.Admin.Carts
{
    public partial class Carts
    {
        [Inject] private ICartManager CartManager { get; set; }

        [CascadingParameter] private HubConnection HubConnection { get; set; }

        private List<GetAllCartsResponse> _cartList = new();
        private GetAllCartsResponse _cart = new();
        private string _searchString = "";
        private bool _dense = false;
        private bool _striped = true;
        private bool _bordered = false;

        private ClaimsPrincipal _currentUser;
        private bool _canCreateCarts;
        private bool _canEditCarts;
        private bool _canDeleteCarts;
        private bool _canExportCarts;
        private bool _canSearchCarts;
        private bool _loaded;

        protected override async Task OnInitializedAsync()
        {
            _currentUser = await _authenticationManager.CurrentUser();
            _canCreateCarts = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Carts.Create)).Succeeded;
            _canEditCarts = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Carts.Edit)).Succeeded;
            _canDeleteCarts = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Carts.Delete)).Succeeded;
            _canExportCarts = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Carts.Export)).Succeeded;
            _canSearchCarts = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Carts.Search)).Succeeded;

            await GetCartsAsync();
            _loaded = true;
            HubConnection = HubConnection.TryInitialize(_navigationManager);
            if (HubConnection.State == HubConnectionState.Disconnected)
            {
                await HubConnection.StartAsync();
            }
        }

        private async Task GetCartsAsync()
        {
            var response = await CartManager.GetAllAsync();
            if (response.Succeeded)
            {
                _cartList = response.Data.ToList();
            }
            else
            {
                foreach (var message in response.Messages)
                {
                    _snackBar.Add(message, Severity.Error);
                }
            }
        }

        private async Task Delete(int id)
        {
            string deleteContent = _localizer["Delete Content"];
            var parameters = new DialogParameters
            {
                {nameof(Shared.Dialogs.DeleteConfirmation.ContentText), string.Format(deleteContent, id)}
            };
            var options = new DialogOptions { CloseButton = true, MaxWidth = MaxWidth.Small, FullWidth = true, DisableBackdropClick = true };
            var dialog = _dialogService.Show<Shared.Dialogs.DeleteConfirmation>(_localizer["Delete"], parameters, options);
            var result = await dialog.Result;
            if (!result.Cancelled)
            {
                var response = await CartManager.DeleteAsync(id);
                if (response.Succeeded)
                {
                    await Reset();
                    await HubConnection.SendAsync(ApplicationConstants.SignalR.SendUpdateDashboard);
                    _snackBar.Add(response.Messages[0], Severity.Success);
                }
                else
                {
                    await Reset();
                    foreach (var message in response.Messages)
                    {
                        _snackBar.Add(message, Severity.Error);
                    }
                }
            }
        }

        private async Task ExportToExcel()
        {
            var response = await CartManager.ExportToExcelAsync(_searchString);
            if (response.Succeeded)
            {
                await _jsRuntime.InvokeVoidAsync("Download", new
                {
                    ByteArray = response.Data,
                    FileName = $"{nameof(Carts).ToLower()}_{DateTime.Now:ddMMyyyyHHmmss}.xlsx",
                    MimeType = ApplicationConstants.MimeTypes.OpenXml
                });
                _snackBar.Add(string.IsNullOrWhiteSpace(_searchString)
                    ? _localizer["Carts exported"]
                    : _localizer["Filtered Carts exported"], Severity.Success);
            }
            else
            {
                foreach (var message in response.Messages)
                {
                    _snackBar.Add(message, Severity.Error);
                }
            }
        }

        private async Task InvokeModal(int id = 0)
        {
            var parameters = new DialogParameters();
            if (id != 0)
            {
                _cart = _cartList.FirstOrDefault(c => c.Id == id);
                if (_cart != null)
                {
                    parameters.Add(nameof(AddEditCartModal.AddEditCartModel), new AddEditCartCommand
                    {
                        Id = _cart.Id,
                        ProductId = _cart.ProductId,
                        Quantity = _cart.Quantity,
                        Product = _cart.Product
                    });
                }
            }
            var options = new DialogOptions { CloseButton = true, MaxWidth = MaxWidth.Small, FullWidth = true, DisableBackdropClick = true };
            var dialog = _dialogService.Show<AddEditCartModal>(id == 0 ? _localizer["Create"] : _localizer["Edit"], parameters, options);
            var result = await dialog.Result;
            if (!result.Cancelled)
            {
                await Reset();
            }
        }

        private async Task Reset()
        {
            _cart = new GetAllCartsResponse();
            await GetCartsAsync();
        }

        private bool Search(GetAllCartsResponse cart)
        {
            if (string.IsNullOrWhiteSpace(_searchString)) return true;
            if (cart.Product.Name?.Contains(_searchString, StringComparison.OrdinalIgnoreCase) == true)
            {
                return true;
            }
            
            return false;
        }
    }
}