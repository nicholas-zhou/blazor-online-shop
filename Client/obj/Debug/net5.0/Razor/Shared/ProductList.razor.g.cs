#pragma checksum "C:\Users\zhoun\Documents\Learning Languages\BlazingShop\Client\Shared\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82d7c7ea00beb1261d98d4564631a0eba03ccece"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingShop.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\zhoun\Documents\Learning Languages\BlazingShop\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zhoun\Documents\Learning Languages\BlazingShop\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\zhoun\Documents\Learning Languages\BlazingShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\zhoun\Documents\Learning Languages\BlazingShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\zhoun\Documents\Learning Languages\BlazingShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\zhoun\Documents\Learning Languages\BlazingShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\zhoun\Documents\Learning Languages\BlazingShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\zhoun\Documents\Learning Languages\BlazingShop\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\zhoun\Documents\Learning Languages\BlazingShop\Client\_Imports.razor"
using BlazingShop.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\zhoun\Documents\Learning Languages\BlazingShop\Client\_Imports.razor"
using BlazingShop.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\zhoun\Documents\Learning Languages\BlazingShop\Client\_Imports.razor"
using BlazingShop.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\zhoun\Documents\Learning Languages\BlazingShop\Client\_Imports.razor"
using BlazingShop.Client.Services.ProductService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\zhoun\Documents\Learning Languages\BlazingShop\Client\_Imports.razor"
using BlazingShop.Client.Services.CategoryService;

#line default
#line hidden
#nullable disable
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "ul");
            __builder.AddAttribute(1, "class", "list-unstyled");
#nullable restore
#line 5 "C:\Users\zhoun\Documents\Learning Languages\BlazingShop\Client\Shared\ProductList.razor"
     foreach (var product in ProductService.Products)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "li");
            __builder.AddAttribute(3, "class", "media my-3");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "media-img-wrapper mr-2");
            __builder.OpenElement(6, "a");
            __builder.AddAttribute(7, "href", "/product/" + (
#nullable restore
#line 9 "C:\Users\zhoun\Documents\Learning Languages\BlazingShop\Client\Shared\ProductList.razor"
                                   product.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(8, "img");
            __builder.AddAttribute(9, "class", "media-img");
            __builder.AddAttribute(10, "src", 
#nullable restore
#line 10 "C:\Users\zhoun\Documents\Learning Languages\BlazingShop\Client\Shared\ProductList.razor"
                                                 product.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "alt", 
#nullable restore
#line 10 "C:\Users\zhoun\Documents\Learning Languages\BlazingShop\Client\Shared\ProductList.razor"
                                                                      product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "media-body");
            __builder.OpenElement(15, "a");
            __builder.AddAttribute(16, "href", "/product/" + (
#nullable restore
#line 14 "C:\Users\zhoun\Documents\Learning Languages\BlazingShop\Client\Shared\ProductList.razor"
                                   product.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(17, "h4");
            __builder.AddAttribute(18, "class", "mb-0");
            __builder.AddContent(19, 
#nullable restore
#line 15 "C:\Users\zhoun\Documents\Learning Languages\BlazingShop\Client\Shared\ProductList.razor"
                                      product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "p");
            __builder.AddContent(22, 
#nullable restore
#line 17 "C:\Users\zhoun\Documents\Learning Languages\BlazingShop\Client\Shared\ProductList.razor"
                    product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 18 "C:\Users\zhoun\Documents\Learning Languages\BlazingShop\Client\Shared\ProductList.razor"
                 if(product.OriginalPrice > product.Price)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "h6");
            __builder.AddAttribute(24, "class", "text-muted original-price");
            __builder.AddContent(25, "$");
            __builder.AddContent(26, 
#nullable restore
#line 20 "C:\Users\zhoun\Documents\Learning Languages\BlazingShop\Client\Shared\ProductList.razor"
                                                            product.OriginalPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\zhoun\Documents\Learning Languages\BlazingShop\Client\Shared\ProductList.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "h5");
            __builder.AddAttribute(28, "class", "price");
            __builder.AddMarkupContent(29, "\r\n                    $");
            __builder.AddContent(30, 
#nullable restore
#line 23 "C:\Users\zhoun\Documents\Learning Languages\BlazingShop\Client\Shared\ProductList.razor"
                      product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Users\zhoun\Documents\Learning Languages\BlazingShop\Client\Shared\ProductList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\zhoun\Documents\Learning Languages\BlazingShop\Client\Shared\ProductList.razor"
            
    //[Parameter]
    //public int? CategoryId { get; set; } = null;

    protected override void OnInitialized()
    {
        //await ProductService.LoadProducts();
        ProductService.OnChange += StateHasChanged;
    }

    public void Dispose()
    {
        ProductService.OnChange -= StateHasChanged;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591
