#pragma checksum "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\App.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "889b84b98a0d545973e29d03770c80a7c2d5cc0aa3488ad46dfea5d831830834"
// <auto-generated/>
#pragma warning disable 1591
namespace LaptopStore.Client
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
    public partial class App : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::LaptopStore.Client.Shared.Error>(0);
            __builder.AddAttribute(1, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.Router>(2);
                __builder2.AddAttribute(3, "AppAssembly", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Reflection.Assembly>(
#nullable restore
#line 2 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\App.razor"
                          typeof(Program).Assembly

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(4, "Found", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder3) => {
                    __builder3.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeRouteView>(5);
                    __builder3.AddAttribute(6, "RouteData", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 4 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\App.razor"
                                            routeData

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(7, "DefaultLayout", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Type>(
#nullable restore
#line 4 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\App.razor"
                                                                       typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(8, "NotAuthorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder4) => {
                        __builder4.OpenComponent<global::LaptopStore.Client.Pages.Authentication.Login>(9);
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(10, "NotFound", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(11);
                    __builder3.AddAttribute(12, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<global::Microsoft.AspNetCore.Components.LayoutView>(13);
                        __builder4.AddAttribute(14, "Layout", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Type>(
#nullable restore
#line 12 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\App.razor"
                                     typeof(NotFoundLayout)

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(15, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(16, "<p>Sorry, there\'s nothing at this address.</p>");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
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
