#pragma checksum "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1336e182f6a1cebd911299e79eebcf88cc38420e15a31abf2ee524978d3f1f2f"
// <auto-generated/>
#pragma warning disable 1591
namespace LaptopStore.Client.Pages.Admin.Brands
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
    public partial class AddEditBrandModal : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 3 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
                  AddEditBrandModel

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(2, "OnValidSubmit", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 3 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
                                                    SaveAsync

#line default
#line hidden
#nullable disable
            ))));
            __builder.AddAttribute(3, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Blazored.FluentValidation.FluentValidationValidator>(4);
                __builder2.AddComponentReferenceCapture(5, (__value) => {
#nullable restore
#line 4 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
                                     _fluentValidationValidator = (Blazored.FluentValidation.FluentValidationValidator)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<global::MudBlazor.MudDialog>(7);
                __builder2.AddAttribute(8, "TitleContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 7 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
              
                if (AddEditBrandModel.Id == 0)
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<global::MudBlazor.MudText>(9);
                    __builder3.AddAttribute(10, "Typo", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 10 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
                                   Typo.h6

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(11, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<global::MudBlazor.MudIcon>(12);
                        __builder4.AddAttribute(13, "Icon", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 11 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
                                        Icons.Material.Filled.Add

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(14, "Class", (object)("mr-3 mb-n1"));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(15, "\r\n                        ");
#nullable restore
#line 12 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
__builder4.AddContent(16, _localizer["Add Brand"]);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 14 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<global::MudBlazor.MudText>(17);
                    __builder3.AddAttribute(18, "Typo", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 17 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
                                   Typo.h6

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(19, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<global::MudBlazor.MudIcon>(20);
                        __builder4.AddAttribute(21, "Icon", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 18 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
                                        Icons.Material.Filled.Update

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(22, "Class", (object)("mr-3 mb-n1"));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(23, "\r\n                        ");
#nullable restore
#line 19 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
__builder4.AddContent(24, _localizer["Update Brand"]);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 21 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
                }
            

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.AddAttribute(25, "DialogContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudGrid>(26);
                    __builder3.AddAttribute(27, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 26 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
                 if (AddEditBrandModel.Id != 0)
                {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<global::MudBlazor.MudItem>(28);
                        __builder4.AddAttribute(29, "xs", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 28 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
                                 12

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(30, "md", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 28 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
                                         6

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(31, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            global::__Blazor.LaptopStore.Client.Pages.Admin.Brands.AddEditBrandModal.TypeInference.CreateMudTextField_0(__builder5, 32, 33, true, 34, 
#nullable restore
#line 29 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
                                                      () => AddEditBrandModel.Id

#line default
#line hidden
#nullable disable
                            , 35, 
#nullable restore
#line 29 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
                                                                                                                              _localizer["Id"]

#line default
#line hidden
#nullable disable
                            , 36, 
#nullable restore
#line 29 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
                                                                                                AddEditBrandModel.Id

#line default
#line hidden
#nullable disable
                            , 37, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AddEditBrandModel.Id = __value, AddEditBrandModel.Id)));
                        }
                        ));
                        __builder4.CloseComponent();
#nullable restore
#line 31 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
                }

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<global::MudBlazor.MudItem>(38);
                        __builder4.AddAttribute(39, "xs", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 32 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
                             12

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(40, "md", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 32 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
                                     6

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(41, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<global::MudBlazor.MudTextField<string>>(42);
                            __builder5.AddAttribute(43, "For", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<global::System.Func<string>>>(
#nullable restore
#line 33 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
                                                    () => AddEditBrandModel.Name

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(44, "Label", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 33 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
                                                                                                                                _localizer["Name"]

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(45, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 33 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
                                                                                                AddEditBrandModel.Name

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(46, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<string>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AddEditBrandModel.Name = __value, AddEditBrandModel.Name)))));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(47, "DialogActions", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudButton>(48);
                    __builder3.AddAttribute(49, "DisableElevation", (object)(true));
                    __builder3.AddAttribute(50, "Variant", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 39 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
                                                 Variant.Filled

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(51, "OnClick", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
                                                                          Cancel

#line default
#line hidden
#nullable disable
                    ))));
                    __builder3.AddAttribute(52, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 39 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
__builder4.AddContent(53, _localizer["Cancel"]);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 40 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
             if (AddEditBrandModel.Id != 0)
            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<global::MudBlazor.MudButton>(54);
                    __builder3.AddAttribute(55, "DisableElevation", (object)(true));
                    __builder3.AddAttribute(56, "Variant", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 42 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
                                                     Variant.Filled

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(57, "ButtonType", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.ButtonType>(
#nullable restore
#line 42 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
                                                                                 ButtonType.Submit

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(58, "Disabled", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 42 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
                                                                                                                !Validated

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(59, "Color", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 42 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
                                                                                                                                    Color.Secondary

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(60, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 42 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
__builder4.AddContent(61, _localizer["Update"]);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 43 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<global::MudBlazor.MudButton>(62);
                    __builder3.AddAttribute(63, "DisableElevation", (object)(true));
                    __builder3.AddAttribute(64, "Variant", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 46 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
                                                     Variant.Filled

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(65, "ButtonType", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.ButtonType>(
#nullable restore
#line 46 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
                                                                                 ButtonType.Submit

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(66, "Disabled", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 46 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
                                                                                                                !Validated

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(67, "Color", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 46 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
                                                                                                                                    Color.Success

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(68, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 46 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
__builder4.AddContent(69, _localizer["Save"]);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 47 "D:\Thai_Van_Tinh\WEB\NET\LaptopStore\Client\Pages\Admin\Brands\AddEditBrandModal.razor"
            }

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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<AddEditBrandModal> _localizer { get; set; }
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
namespace __Blazor.LaptopStore.Client.Pages.Admin.Brands.AddEditBrandModal
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg1, int __seq2, global::System.String __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Disabled", (object)__arg0);
        __builder.AddAttribute(__seq1, "For", (object)__arg1);
        __builder.AddAttribute(__seq2, "Label", (object)__arg2);
        __builder.AddAttribute(__seq3, "Value", (object)__arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", (object)__arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591