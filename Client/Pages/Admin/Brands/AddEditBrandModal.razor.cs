using LaptopStore.Client.Extensions;
using LaptopStore.Shared.Constants.Application;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using MudBlazor;
using System.Threading.Tasks;
using Blazored.FluentValidation;
using LaptopStore.Application.Features.Brands.Commands.AddEdit;
using LaptopStore.Client.Infrastructure.Managers.Catalog.Brand;
using System.Collections.Generic;

namespace LaptopStore.Client.Pages.Admin.Brands
{
    public partial class AddEditBrandModal
    {
        [Inject] private IBrandManager BrandManager { get; set; }

        [Parameter] public AddEditBrandCommand AddEditBrandModel { get; set; } = new();
        [CascadingParameter] private MudDialogInstance MudDialog { get; set; }
        [CascadingParameter] private HubConnection HubConnection { get; set; }

        private FluentValidationValidator _fluentValidationValidator;
        private bool Validated => _fluentValidationValidator.Validate(options => { options.IncludeAllRuleSets(); });

        private void Cancel()
        {
            MudDialog.Cancel();
        }

        private async Task SaveAsync()
        {
            var response = await BrandManager.SaveAsync(AddEditBrandModel);
            if (response.Succeeded)
            {
                _snackBar.Add(response.Messages[0], Severity.Success);
                MudDialog.Close();
            }
            else
            {
                foreach (var message in response.Messages)
                {
                    _snackBar.Add(message, Severity.Error);
                }
            }
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

        private void AddProductLine()
        {
            AddEditBrandModel.ProductLines.Add(string.Empty);  // Thêm một dòng sản phẩm mới
        }


        private void RemoveProductLine(int index)
        {
            if (index >= 0 && index < AddEditBrandModel.ProductLines.Count)
            {
                AddEditBrandModel.ProductLines.RemoveAt(index);
            }
        }


        private async Task LoadDataAsync()
        {
            await Task.CompletedTask;
        }
    }
}
