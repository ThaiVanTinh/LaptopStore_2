#pragma checksum "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Shared\Components\LanguageSelector.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "de64735735f3d83bf1233704e1a7139b69607bd8f9232d62362a1f7d17dee186"
// <auto-generated/>
#pragma warning disable 1591
namespace LaptopStore.Client.Shared.Components
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
#line 1 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Shared\Components\LanguageSelector.razor"
using LaptopStore.Shared.Constants.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable
    public partial class LanguageSelector : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::MudBlazor.MudMenu>(0);
            __builder.AddAttribute(1, "Icon", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 2 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Shared\Components\LanguageSelector.razor"
                Icons.Material.Outlined.Translate

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(2, "Color", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 2 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Shared\Components\LanguageSelector.razor"
                                                          Color.Inherit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "Direction", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Direction>(
#nullable restore
#line 2 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Shared\Components\LanguageSelector.razor"
                                                                                    Direction.Bottom

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "OffsetY", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 2 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Shared\Components\LanguageSelector.razor"
                                                                                                               true

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "Dense", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 2 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Shared\Components\LanguageSelector.razor"
                                                                                                                            true

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 3 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Shared\Components\LanguageSelector.razor"
     foreach (var language in LocalizationConstants.SupportedLanguages)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::MudBlazor.MudMenuItem>(7);
                __builder2.AddAttribute(8, "OnClick", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Shared\Components\LanguageSelector.razor"
                              (()=> ChangeLanguageAsync(language.Code))

#line default
#line hidden
#nullable disable
                ))));
                __builder2.AddAttribute(9, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 5 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Shared\Components\LanguageSelector.razor"
__builder3.AddContent(10, language.DisplayName);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 6 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Shared\Components\LanguageSelector.razor"
    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Shared\Components\LanguageSelector.razor"
 
    private async Task ChangeLanguageAsync(string languageCode)
    {
        var result = await _clientPreferenceManager.ChangeLanguageAsync(languageCode);
        if (result.Succeeded)
        {
            _snackBar.Add(result.Messages[0], Severity.Success);
            _navigationManager.NavigateTo(_navigationManager.Uri, forceLoad: true);
        }
        else
        {
            foreach (var error in result.Messages)
            {
                _snackBar.Add(error, Severity.Error);
            }
        }
    }

#line default
#line hidden
#nullable disable
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