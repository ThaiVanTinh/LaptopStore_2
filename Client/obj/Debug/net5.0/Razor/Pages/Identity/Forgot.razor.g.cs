#pragma checksum "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Identity\Forgot.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1bb72e96ed57d242dd544d02e936aacb2163d1835e26b8c913ded4e09f8b5bd6"
// <auto-generated/>
#pragma warning disable 1591
namespace LaptopStore.Client.Pages.Identity
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
#nullable restore
#line 3 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Identity\Forgot.razor"
           [AllowAnonymous]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/account/forgot-password")]
    public partial class Forgot : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 6 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Identity\Forgot.razor"
                  _emailModel

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(2, "OnValidSubmit", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Identity\Forgot.razor"
                                              SubmitAsync

#line default
#line hidden
#nullable disable
            ))));
            __builder.AddAttribute(3, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Blazored.FluentValidation.FluentValidationValidator>(4);
                __builder2.AddComponentReferenceCapture(5, (__value) => {
#nullable restore
#line 7 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Identity\Forgot.razor"
                                     _fluentValidationValidator = (Blazored.FluentValidation.FluentValidationValidator)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<global::MudBlazor.MudGrid>(7);
                __builder2.AddAttribute(8, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudItem>(9);
                    __builder3.AddAttribute(10, "xs", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 9 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Identity\Forgot.razor"
                     12

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(11, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(12, "div");
                        __builder4.AddAttribute(13, "class", "d-flex justify-center");
                        __builder4.OpenComponent<global::MudBlazor.MudIcon>(14);
                        __builder4.AddAttribute(15, "Icon", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 11 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Identity\Forgot.razor"
                                CustomIcons.BlazorHero

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(16, "Color", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 11 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Identity\Forgot.razor"
                                                               Color.Primary

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(17, "Size", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Size>(
#nullable restore
#line 11 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Identity\Forgot.razor"
                                                                                    Size.Large

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(18, "ViewBox", (object)("0 0 500 500"));
                        __builder4.AddAttribute(19, "Style", (object)("width: 100px; height: 100px;"));
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(20, "\r\n        ");
                    __builder3.OpenComponent<global::MudBlazor.MudItem>(21);
                    __builder3.AddAttribute(22, "xs", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 14 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Identity\Forgot.razor"
                     12

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(23, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(24, "div");
                        __builder4.AddAttribute(25, "class", "d-flex justify-center");
                        __builder4.OpenComponent<global::MudBlazor.MudText>(26);
                        __builder4.AddAttribute(27, "Typo", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 16 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Identity\Forgot.razor"
                               Typo.h4

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(28, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
#nullable restore
#line 16 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Identity\Forgot.razor"
__builder5.AddContent(29, _localizer["Forgot password?"]);

#line default
#line hidden
#nullable disable
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(30, "\r\n        ");
                    __builder3.OpenComponent<global::MudBlazor.MudItem>(31);
                    __builder3.AddAttribute(32, "xs", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 19 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Identity\Forgot.razor"
                     12

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(33, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(34, "div");
                        __builder4.AddAttribute(35, "class", "d-flex justify-center");
                        __builder4.OpenComponent<global::MudBlazor.MudText>(36);
                        __builder4.AddAttribute(37, "Typo", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 21 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Identity\Forgot.razor"
                               Typo.subtitle2

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(38, "Class", (object)("mb-n4"));
                        __builder4.AddAttribute(39, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
#nullable restore
#line 21 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Identity\Forgot.razor"
__builder5.AddContent(40, _localizer["Enter email for password reset"]);

#line default
#line hidden
#nullable disable
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\r\n        ");
                    __builder3.OpenComponent<global::MudBlazor.MudItem>(42);
                    __builder3.AddAttribute(43, "xs", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 24 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Identity\Forgot.razor"
                     12

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(44, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        global::__Blazor.LaptopStore.Client.Pages.Identity.Forgot.TypeInference.CreateMudTextField_0(__builder4, 45, 46, 
#nullable restore
#line 25 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Identity\Forgot.razor"
                                  _localizer["E-mail"]

#line default
#line hidden
#nullable disable
                        , 47, 
#nullable restore
#line 25 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Identity\Forgot.razor"
                                                                                               () => _emailModel.Email

#line default
#line hidden
#nullable disable
                        , 48, 
#nullable restore
#line 25 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Identity\Forgot.razor"
                                                                                                                                  Variant.Outlined

#line default
#line hidden
#nullable disable
                        , 49, 
#nullable restore
#line 25 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Identity\Forgot.razor"
                                                                     _emailModel.Email

#line default
#line hidden
#nullable disable
                        , 50, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _emailModel.Email = __value, _emailModel.Email)));
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(51, "\r\n        ");
                    __builder3.OpenComponent<global::MudBlazor.MudItem>(52);
                    __builder3.AddAttribute(53, "xs", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 27 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Identity\Forgot.razor"
                     12

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(54, "Class", (object)("d-flex justify-center"));
                    __builder3.AddAttribute(55, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<global::MudBlazor.MudButton>(56);
                        __builder4.AddAttribute(57, "Variant", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 28 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Identity\Forgot.razor"
                                Variant.Filled

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(58, "Disabled", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 28 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Identity\Forgot.razor"
                                                            !Validated

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(59, "Color", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 28 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Identity\Forgot.razor"
                                                                                Color.Primary

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(60, "Size", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Size>(
#nullable restore
#line 28 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Identity\Forgot.razor"
                                                                                                     Size.Large

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(61, "ButtonType", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.ButtonType>(
#nullable restore
#line 28 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Identity\Forgot.razor"
                                                                                                                             ButtonType.Submit

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(62, "FullWidth", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 28 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Identity\Forgot.razor"
                                                                                                                                                           true

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(63, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
#nullable restore
#line 28 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Identity\Forgot.razor"
__builder5.AddContent(64, _localizer["Reset Password"]);

#line default
#line hidden
#nullable disable
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<Forgot> _localizer { get; set; }
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
namespace __Blazor.LaptopStore.Client.Pages.Identity.Forgot
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg1, int __seq2, global::MudBlazor.Variant __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", (object)__arg0);
        __builder.AddAttribute(__seq1, "For", (object)__arg1);
        __builder.AddAttribute(__seq2, "Variant", (object)__arg2);
        __builder.AddAttribute(__seq3, "Value", (object)__arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", (object)__arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
