#pragma checksum "D:\Projects\Suchimu\Client\Pages\GameDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a22fe267b1f92f3f81e652babffb51311ef95c9"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/game/{id:int}")]
    public partial class GameDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row mb-3");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-md-5 col-sm-12");
            __builder.OpenElement(4, "h2");
            __builder.AddAttribute(5, "class", "font-weight-bolder");
            __builder.AddContent(6, 
#nullable restore
#line 9 "D:\Projects\Suchimu\Client\Pages\GameDetails.razor"
                                        game.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "img");
            __builder.AddAttribute(9, "src", 
#nullable restore
#line 10 "D:\Projects\Suchimu\Client\Pages\GameDetails.razor"
                   game.ImageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "class", "img-fluid");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-md-7 col-sm-12");
            __builder.AddMarkupContent(14, "<br><br>\r\n        ");
            __builder.OpenElement(15, "p");
            __builder.AddContent(16, "Create Time: ");
            __builder.AddContent(17, 
#nullable restore
#line 14 "D:\Projects\Suchimu\Client\Pages\GameDetails.razor"
                         game.CreateDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "p");
            __builder.AddContent(20, "Price: ");
            __builder.AddContent(21, 
#nullable restore
#line 15 "D:\Projects\Suchimu\Client\Pages\GameDetails.razor"
                   game.OriginalPrice

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(22, " $");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "p");
            __builder.AddContent(25, "New price: ");
            __builder.OpenElement(26, "b");
            __builder.AddContent(27, 
#nullable restore
#line 16 "D:\Projects\Suchimu\Client\Pages\GameDetails.razor"
                          game.Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(28, " $");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "class", "btn btn-danger");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "D:\Projects\Suchimu\Client\Pages\GameDetails.razor"
                                                 AddToCart

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(33, "<i class=\"oi oi-cart\"></i>&nbsp;&nbsp;Thêm vào giỏ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
            __builder.OpenElement(35, "p");
            __builder.AddMarkupContent(36, "<h3 class=\"font-weight-bold\">Description</h3> ");
            __builder.AddContent(37, 
#nullable restore
#line 20 "D:\Projects\Suchimu\Client\Pages\GameDetails.razor"
                                                  game.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "D:\Projects\Suchimu\Client\Pages\GameDetails.razor"
       
    [Parameter]
    public int Id { get; set; }

    private Game game = new Game();

    protected override async Task OnParametersSetAsync()
    {
        //if(GameService.Games == null || GameService.Games.Count == 0)
        //{
        //    GameService.LoadGames();
        //}
        GameService.LoadGames();
        game = await GameService.GetGame(Id);
    }

    private async Task AddToCart()
    {
        await CartService.AddToCart(game);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICartService CartService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGameService GameService { get; set; }
    }
}
#pragma warning restore 1591