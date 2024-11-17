using LaptopStore.Domain.Entities.Catalog;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System.Collections.Generic;

namespace LaptopStore.Client.Pages.Admin.Orders
{
    public partial class ViewProductsOrder
    {
        [CascadingParameter] MudDialogInstance MudDialog { get; set; }
        [Parameter] public ICollection<CartItem> OrderItems { get; set; }

        private void CloseDialog()
        {
            MudDialog.Close();
        }
    }
}
