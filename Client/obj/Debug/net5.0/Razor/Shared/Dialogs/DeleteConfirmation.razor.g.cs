#pragma checksum "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Shared\Dialogs\DeleteConfirmation.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0491c5eac2b6e2eec2a2d7dc75019befb9c40ae80b939127044a909f3c39c8f6"
// <auto-generated/>
#pragma warning disable 1591
namespace LaptopStore.Client.Shared.Dialogs
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Infrastructure.Managers.Identity.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Infrastructure.Managers.Identity.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Infrastructure.Managers.Identity.Roles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Infrastructure.Managers.Identity.RoleClaims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Infrastructure.Managers.Identity.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Infrastructure.Managers.Preferences;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Infrastructure.Managers.Interceptors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Infrastructure.Managers.Catalog.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Infrastructure.Managers.Catalog.Brand;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Infrastructure.Managers.Dashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Infrastructure.Managers.Audit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\_Imports.razor"
using LaptopStore.Shared.Constants.Permission;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Shared.Dialogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Infrastructure.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\_Imports.razor"
using LaptopStore.Application.Requests.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Pages.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Infrastructure.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable
    public partial class DeleteConfirmation : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::MudBlazor.MudDialog>(0);
            __builder.AddAttribute(1, "TitleContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudText>(2);
                __builder2.AddAttribute(3, "Typo", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 5 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Shared\Dialogs\DeleteConfirmation.razor"
                       Typo.h6

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(4, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudIcon>(5);
                    __builder3.AddAttribute(6, "Icon", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 6 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Shared\Dialogs\DeleteConfirmation.razor"
                            Icons.Material.Filled.Delete

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(7, "Class", (object)("mr-3 mb-n1"));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(8, "\r\n            ");
#nullable restore
#line 7 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Shared\Dialogs\DeleteConfirmation.razor"
__builder3.AddContent(9, localizer["Delete Confirmation"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(10, "DialogContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudText>(11);
                __builder2.AddAttribute(12, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 11 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Shared\Dialogs\DeleteConfirmation.razor"
__builder3.AddContent(13, ContentText);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(14, "DialogActions", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudButton>(15);
                __builder2.AddAttribute(16, "OnClick", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Shared\Dialogs\DeleteConfirmation.razor"
                            Cancel

#line default
#line hidden
#nullable disable
                ))));
                __builder2.AddAttribute(17, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 14 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Shared\Dialogs\DeleteConfirmation.razor"
__builder3.AddContent(18, localizer["Cancel"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenComponent<global::MudBlazor.MudButton>(20);
                __builder2.AddAttribute(21, "Color", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 15 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Shared\Dialogs\DeleteConfirmation.razor"
                          Color.Error

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(22, "Variant", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 15 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Shared\Dialogs\DeleteConfirmation.razor"
                                                Variant.Filled

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(23, "OnClick", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Shared\Dialogs\DeleteConfirmation.razor"
                                                                         Submit

#line default
#line hidden
#nullable disable
                ))));
                __builder2.AddAttribute(24, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 15 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Shared\Dialogs\DeleteConfirmation.razor"
__builder3.AddContent(25, localizer["Confirm"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Shared\Dialogs\DeleteConfirmation.razor"
       
    [CascadingParameter] MudDialogInstance MudDialog { get; set; }

    [Parameter] public string ContentText { get; set; }

    void Submit()
    {
        MudDialog.Close(DialogResult.Ok(true));
    }
    void Cancel() => MudDialog.Cancel();

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<DeleteConfirmation> localizer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService _localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserManager _userManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClientPreferenceManager _clientPreferenceManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpInterceptorManager _interceptor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _httpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService _dialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar _snackBar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthorizationService _authorizationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorHeroStateProvider _stateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountManager _accountManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthenticationManager _authenticationManager { get; set; }
    }
}
#pragma warning restore 1591
