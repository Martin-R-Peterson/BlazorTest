#pragma checksum "C:\Users\marti\Documents\Skola\BlazorTest\Pages\Shop.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74cb19815d489b8769f7198952c2d5857dd08d6a"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorTest.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\marti\Documents\Skola\BlazorTest\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\marti\Documents\Skola\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\marti\Documents\Skola\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\marti\Documents\Skola\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\marti\Documents\Skola\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\marti\Documents\Skola\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\marti\Documents\Skola\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\marti\Documents\Skola\BlazorTest\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\marti\Documents\Skola\BlazorTest\_Imports.razor"
using BlazorTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\marti\Documents\Skola\BlazorTest\_Imports.razor"
using BlazorTest.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/shop")]
    public partial class Shop : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Shop</h1>\r\n");
            __builder.AddMarkupContent(1, "<h4>Lägg till Produkter</h4>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddMarkupContent(3, "<label class=\"label\" for=\"name\">Namn:</label>\r\n    ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "text");
            __builder.AddAttribute(6, "id", "name");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\marti\Documents\Skola\BlazorTest\Pages\Shop.razor"
                              tempName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tempName = __value, tempName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.AddMarkupContent(10, "<label for=\"desc\">Beskrivning:</label>\r\n    ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "text");
            __builder.AddAttribute(13, "id", "desc");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\marti\Documents\Skola\BlazorTest\Pages\Shop.razor"
                              tempDescription

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tempDescription = __value, tempDescription));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.AddMarkupContent(17, "<label for=\"price\">Pris:</label>\r\n    ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "type", "number");
            __builder.AddAttribute(20, "id", "price");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\marti\Documents\Skola\BlazorTest\Pages\Shop.razor"
                                tempPrice

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tempPrice = __value, tempPrice, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.AddMarkupContent(24, "<label for=\"link\">Bild-Länk:</label>\r\n    ");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "id", "bild");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\marti\Documents\Skola\BlazorTest\Pages\Shop.razor"
                  tempLink

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tempLink = __value, tempLink));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\marti\Documents\Skola\BlazorTest\Pages\Shop.razor"
                      AddProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(32, "Add Product");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\r\n");
            __builder.AddMarkupContent(34, "<h2>Produkter</h2>\r\n");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "card-deck");
#nullable restore
#line 22 "C:\Users\marti\Documents\Skola\BlazorTest\Pages\Shop.razor"
     foreach (var product in Products)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "card w-50");
            __builder.OpenElement(39, "img");
            __builder.AddAttribute(40, "class", "card-img-top");
            __builder.AddAttribute(41, "src", 
#nullable restore
#line 25 "C:\Users\marti\Documents\Skola\BlazorTest\Pages\Shop.razor"
                                           product.Link

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(42, "style", ".card-img-top{ width: 300px !important}");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "card-body");
            __builder.OpenElement(46, "h5");
            __builder.AddAttribute(47, "class", "card-title");
            __builder.AddContent(48, "Namn: ");
            __builder.AddContent(49, 
#nullable restore
#line 27 "C:\Users\marti\Documents\Skola\BlazorTest\Pages\Shop.razor"
                                              product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.OpenElement(51, "p");
            __builder.AddAttribute(52, "class", "card-text");
            __builder.AddContent(53, "Beskrivning: ");
            __builder.AddContent(54, 
#nullable restore
#line 28 "C:\Users\marti\Documents\Skola\BlazorTest\Pages\Shop.razor"
                                                   product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.OpenElement(56, "p");
            __builder.AddAttribute(57, "class", "card-text");
            __builder.AddContent(58, "Pris: ");
            __builder.AddContent(59, 
#nullable restore
#line 29 "C:\Users\marti\Documents\Skola\BlazorTest\Pages\Shop.razor"
                                            product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(60, " kr");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                ");
            __builder.AddMarkupContent(62, "<a href=\"#\" class=\"btn btn-primary\">Köp</a>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 33 "C:\Users\marti\Documents\Skola\BlazorTest\Pages\Shop.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\marti\Documents\Skola\BlazorTest\Pages\Shop.razor"
       
    private List<ProductItems> Products = new();
    private string? tempName;
    private string tempDescription;
    private int tempPrice;

    private string tempLink;

    private void AddProduct()
    {
        if (!string.IsNullOrWhiteSpace(tempName))
        {
            Products.Add(new ProductItems { Name = tempName, Description = tempDescription, Price = tempPrice, Link = tempLink });
            tempName = string.Empty;
            tempDescription = string.Empty;
            tempPrice = 0;
        }
    }

    protected override async Task OnInitializedAsync()
    {
        Products.Add(new ProductItems
        {
            Name = "Nvidia GTX 970",
            Description = "Bra Grafikkort",
            Price = 1500,
            Link =
        "https://tpucdn.com/gpu-specs/images/c/2620-front.jpg"
        });
        Products.Add(new ProductItems
        {
            Name = "Nvidia RTX 2060",
            Description = "Bättre Grafikkort",
            Price = 4000,
            Link =
        "https://m.media-amazon.com/images/I/71vhQ8OjsAL.jpg"
        });
        Products.Add(new ProductItems
        {
            Name = "Nvidia RTX 3080",
            Description = "Bäst Grafikkort",
            Price = 10000,
            Link =
        "https://i5.walmartimages.com/asr/92315d04-9c63-4997-abcf-aa8abfee1ef4.91e4e15558ca6150bbf4d4d5392bf639.jpeg"
        });

    }




#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591