// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LaptopStore.Client.Pages.Identity
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 3 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using System.Net.Http.Json

#nullable disable
    ;
#nullable restore
#line 4 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization

#nullable disable
    ;
#nullable restore
#line 5 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization

#nullable disable
    ;
#nullable restore
#line 6 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line 7 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 8 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 9 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization

#nullable disable
    ;
#nullable restore
#line 10 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http

#nullable disable
    ;
#nullable restore
#line 11 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line 12 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#nullable disable
#nullable restore
#line 13 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using MudBlazor

#nullable disable
    ;
#nullable restore
#line 14 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using Blazored.LocalStorage;

#nullable disable
#nullable restore
#line 15 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using Blazored.FluentValidation

#nullable disable
    ;
#nullable restore
#line 18 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Infrastructure.Managers.Identity.Account

#nullable disable
    ;
#nullable restore
#line 19 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Infrastructure.Managers.Identity.Authentication

#nullable disable
    ;
#nullable restore
#line 20 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Infrastructure.Managers.Identity.Roles

#nullable disable
    ;
#nullable restore
#line 21 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Infrastructure.Managers.Identity.RoleClaims

#nullable disable
    ;
#nullable restore
#line 22 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Infrastructure.Managers.Identity.Users

#nullable disable
    ;
#nullable restore
#line 23 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Infrastructure.Managers.Preferences

#nullable disable
    ;
#nullable restore
#line 24 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Infrastructure.Managers.Interceptors

#nullable disable
    ;
#nullable restore
#line 25 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Infrastructure.Managers.Catalog.Product

#nullable disable
    ;
#nullable restore
#line 26 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Infrastructure.Managers.Catalog.Brand

#nullable disable
    ;
#nullable restore
#line 27 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Infrastructure.Managers.Dashboard

#nullable disable
    ;
#nullable restore
#line 28 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Infrastructure.Managers.Communication

#nullable disable
    ;
#nullable restore
#line 29 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Infrastructure.Managers.Audit

#nullable disable
    ;
#nullable restore
#line 30 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Infrastructure.Managers.Misc.Document

#nullable disable
    ;
#nullable restore
#line 31 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Infrastructure.Managers.Misc.DocumentType

#nullable disable
    ;
#nullable restore
#line 34 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using LaptopStore.Shared.Constants.Permission

#nullable disable
    ;
#nullable restore
#line 35 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Shared.Components

#nullable disable
    ;
#nullable restore
#line 37 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client

#nullable disable
    ;
#nullable restore
#line 38 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Shared

#nullable disable
    ;
#nullable restore
#line 39 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Shared.Dialogs

#nullable disable
    ;
#nullable restore
#line 40 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Infrastructure.Settings

#nullable disable
    ;
#nullable restore
#line 42 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using LaptopStore.Application.Requests.Identity

#nullable disable
    ;
#nullable restore
#line 44 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Pages.Authentication

#nullable disable
    ;
#nullable restore
#line 46 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Infrastructure.Authentication

#nullable disable
    ;
#nullable restore
#line 47 "D:\18d11m\LaptopStore\Client\_Imports.razor"
using LaptopStore.Client.Extensions

#line default
#line hidden
#nullable disable
    ;
#nullable restore
#line 49 "D:\18d11m\LaptopStore\Client\_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable

    #nullable restore
    public partial class RegisterUserModal : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 1 "D:\18d11m\LaptopStore\Client\Pages\Identity\RegisterUserModal.razor"
        Microsoft.Extensions.Localization.IStringLocalizer<RegisterUserModal>

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 1 "D:\18d11m\LaptopStore\Client\Pages\Identity\RegisterUserModal.razor"
                                                                              _localizer

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 62 "D:\18d11m\LaptopStore\Client\_Imports.razor"
IJSRuntime

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 62 "D:\18d11m\LaptopStore\Client\_Imports.razor"
_jsRuntime

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 61 "D:\18d11m\LaptopStore\Client\_Imports.razor"
ILocalStorageService

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 61 "D:\18d11m\LaptopStore\Client\_Imports.razor"
_localStorage

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 60 "D:\18d11m\LaptopStore\Client\_Imports.razor"
IUserManager

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 60 "D:\18d11m\LaptopStore\Client\_Imports.razor"
_userManager

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 59 "D:\18d11m\LaptopStore\Client\_Imports.razor"
ClientPreferenceManager

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 59 "D:\18d11m\LaptopStore\Client\_Imports.razor"
_clientPreferenceManager

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 58 "D:\18d11m\LaptopStore\Client\_Imports.razor"
IHttpInterceptorManager

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 58 "D:\18d11m\LaptopStore\Client\_Imports.razor"
_interceptor

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 57 "D:\18d11m\LaptopStore\Client\_Imports.razor"
HttpClient

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 57 "D:\18d11m\LaptopStore\Client\_Imports.razor"
_httpClient

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 56 "D:\18d11m\LaptopStore\Client\_Imports.razor"
IDialogService

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 56 "D:\18d11m\LaptopStore\Client\_Imports.razor"
_dialogService

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 55 "D:\18d11m\LaptopStore\Client\_Imports.razor"
ISnackbar

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 55 "D:\18d11m\LaptopStore\Client\_Imports.razor"
_snackBar

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 54 "D:\18d11m\LaptopStore\Client\_Imports.razor"
IAuthorizationService

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 54 "D:\18d11m\LaptopStore\Client\_Imports.razor"
_authorizationService

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 53 "D:\18d11m\LaptopStore\Client\_Imports.razor"
BlazorHeroStateProvider

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 53 "D:\18d11m\LaptopStore\Client\_Imports.razor"
_stateProvider

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 52 "D:\18d11m\LaptopStore\Client\_Imports.razor"
NavigationManager

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 52 "D:\18d11m\LaptopStore\Client\_Imports.razor"
_navigationManager

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 51 "D:\18d11m\LaptopStore\Client\_Imports.razor"
IAccountManager

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 51 "D:\18d11m\LaptopStore\Client\_Imports.razor"
_accountManager

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 50 "D:\18d11m\LaptopStore\Client\_Imports.razor"
IAuthenticationManager

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 50 "D:\18d11m\LaptopStore\Client\_Imports.razor"
_authenticationManager

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
#pragma warning restore 1591
