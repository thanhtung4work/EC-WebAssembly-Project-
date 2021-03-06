#pragma checksum "D:\Projects\Suchimu\Client\Pages\Cart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ead0b6d84fe6e989c36c175124de464e77eab61"
// <auto-generated/>
#pragma warning disable 1591
namespace Suchimu.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\Suchimu\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\Suchimu\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\Suchimu\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\Suchimu\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\Suchimu\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\Suchimu\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\Suchimu\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\Suchimu\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\Suchimu\Client\_Imports.razor"
using Suchimu.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\Suchimu\Client\_Imports.razor"
using Suchimu.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projects\Suchimu\Client\_Imports.razor"
using Suchimu.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Projects\Suchimu\Client\_Imports.razor"
using Suchimu.Client.Services.GameService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Projects\Suchimu\Client\_Imports.razor"
using Suchimu.Client.Services.CategoryService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Projects\Suchimu\Client\_Imports.razor"
using Suchimu.Client.Services.StudioService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Projects\Suchimu\Client\_Imports.razor"
using Suchimu.Client.Services.StatsService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Projects\Suchimu\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Projects\Suchimu\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Projects\Suchimu\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Projects\Suchimu\Client\_Imports.razor"
using Suchimu.Client.Services.CartService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Projects\Suchimu\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Projects\Suchimu\Client\_Imports.razor"
using Suchimu.Client.Services.UserService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Projects\Suchimu\Client\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cart")]
    public partial class Cart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 b-lnlx6rw7se>Cart</h3>");
#nullable restore
#line 7 "D:\Projects\Suchimu\Client\Pages\Cart.razor"
 if (cartItems == null || cartItems.Count <= 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p b-lnlx6rw7se>Gi??? h??ng tr???ng.</p>");
#nullable restore
#line 10 "D:\Projects\Suchimu\Client\Pages\Cart.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "b-lnlx6rw7se");
#nullable restore
#line 14 "D:\Projects\Suchimu\Client\Pages\Cart.razor"
         foreach(var item in cartItems)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "item-container");
            __builder.AddAttribute(6, "b-lnlx6rw7se");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "item-image-wrapper");
            __builder.AddAttribute(9, "b-lnlx6rw7se");
            __builder.OpenElement(10, "img");
            __builder.AddAttribute(11, "src", 
#nullable restore
#line 17 "D:\Projects\Suchimu\Client\Pages\Cart.razor"
                                                           item.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "class", "item-image");
            __builder.AddAttribute(13, "b-lnlx6rw7se");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "item-name");
            __builder.AddAttribute(17, "b-lnlx6rw7se");
            __builder.OpenElement(18, "h4");
            __builder.AddAttribute(19, "b-lnlx6rw7se");
            __builder.OpenElement(20, "a");
            __builder.AddAttribute(21, "href", "/game/" + (
#nullable restore
#line 19 "D:\Projects\Suchimu\Client\Pages\Cart.razor"
                                        item.GameId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "b-lnlx6rw7se");
            __builder.AddContent(23, 
#nullable restore
#line 19 "D:\Projects\Suchimu\Client\Pages\Cart.razor"
                                                      item.GameTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "class", "btn btn-danger");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "D:\Projects\Suchimu\Client\Pages\Cart.razor"
                                                               ()=>DeleteItem(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "b-lnlx6rw7se");
            __builder.AddMarkupContent(29, "X??a");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "item-price");
            __builder.AddAttribute(33, "b-lnlx6rw7se");
            __builder.AddContent(34, 
#nullable restore
#line 22 "D:\Projects\Suchimu\Client\Pages\Cart.razor"
                                         item.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 24 "D:\Projects\Suchimu\Client\Pages\Cart.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.OpenElement(36, "h5");
            __builder.AddAttribute(37, "class", "item-total-price");
            __builder.AddAttribute(38, "b-lnlx6rw7se");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "D:\Projects\Suchimu\Client\Pages\Cart.razor"
                          DeleteItemAll

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "b-lnlx6rw7se");
            __builder.AddContent(42, "Mua");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n        Total (");
            __builder.AddContent(44, 
#nullable restore
#line 28 "D:\Projects\Suchimu\Client\Pages\Cart.razor"
                cartItems.Count

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(45, "): $");
            __builder.AddContent(46, 
#nullable restore
#line 28 "D:\Projects\Suchimu\Client\Pages\Cart.razor"
                                    cartItems.Sum(item => item.Price)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(47, ";\r\n    ");
            __builder.CloseElement();
#nullable restore
#line 30 "D:\Projects\Suchimu\Client\Pages\Cart.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "D:\Projects\Suchimu\Client\Pages\Cart.razor"
       
    List<CartItem> cartItems = new List<CartItem>();

    protected override async Task OnInitializedAsync()
    {
        cartItems = await CartService.GetCartItems();
    }

    private async Task DeleteItemAll()
    {
        foreach(var item in cartItems)
        {
            await CartService.DeleteItem(item);
        }
        ToastService.ShowSuccess("Giao d???ch ok ", "Mua h??ng th??nh th???");
        cartItems = await CartService.GetCartItems();
    }

    private async Task DeleteItem(CartItem item)
    {
        await CartService.DeleteItem(item);
        cartItems = await CartService.GetCartItems();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICartService CartService { get; set; }
    }
}
#pragma warning restore 1591
