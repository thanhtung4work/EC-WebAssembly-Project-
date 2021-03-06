#pragma checksum "D:\Projects\Suchimu\Client\Pages\ListGames.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e35a1ef1f3875ecd4671a774a51fc6d813482b18"
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
    public partial class ListGames : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Games</h3>\r\n");
            __builder.OpenElement(1, "ul");
            __builder.AddAttribute(2, "class", "list-unstyled row mx-1");
#nullable restore
#line 9 "D:\Projects\Suchimu\Client\Pages\ListGames.razor"
     foreach (var myGame in GameService.Games)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "li");
            __builder.AddAttribute(4, "class", "media mt-3 col-md-6 col-sm-12 hoverable-img");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class");
            __builder.OpenElement(7, "a");
            __builder.AddAttribute(8, "href", "/game/" + (
#nullable restore
#line 13 "D:\Projects\Suchimu\Client\Pages\ListGames.razor"
                                myGame.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(9, "img");
            __builder.AddAttribute(10, "class", "img-thumbnail");
            __builder.AddAttribute(11, "style", "width: 200px;");
            __builder.AddAttribute(12, "src", 
#nullable restore
#line 14 "D:\Projects\Suchimu\Client\Pages\ListGames.razor"
                                                                          myGame.ImageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "alt", 
#nullable restore
#line 14 "D:\Projects\Suchimu\Client\Pages\ListGames.razor"
                                                                                                myGame.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "media-body ml-3");
            __builder.OpenElement(17, "a");
            __builder.AddAttribute(18, "href", "/game/" + (
#nullable restore
#line 18 "D:\Projects\Suchimu\Client\Pages\ListGames.razor"
                                myGame.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(19, "h4");
            __builder.AddContent(20, 
#nullable restore
#line 19 "D:\Projects\Suchimu\Client\Pages\ListGames.razor"
                         myGame.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "p");
            __builder.AddContent(23, 
#nullable restore
#line 21 "D:\Projects\Suchimu\Client\Pages\ListGames.razor"
                    myGame.ShortDescription

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "p");
            __builder.AddContent(26, 
#nullable restore
#line 22 "D:\Projects\Suchimu\Client\Pages\ListGames.razor"
                    myGame.Description.Substring(0, 15)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(27, " ...");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "p");
            __builder.AddContent(30, 
#nullable restore
#line 23 "D:\Projects\Suchimu\Client\Pages\ListGames.razor"
                    myGame.OriginalPrice

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(31, " ??");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenElement(33, "h3");
            __builder.AddContent(34, 
#nullable restore
#line 24 "D:\Projects\Suchimu\Client\Pages\ListGames.razor"
                     myGame.Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(35, " ??");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 27 "D:\Projects\Suchimu\Client\Pages\ListGames.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "D:\Projects\Suchimu\Client\Pages\ListGames.razor"
       
    // [Parameter]
    // public string CategoryUrl { get; set; } = null;

    // private Category category { get; set; } = null;

    protected override void OnInitialized()
    {
        // await GameService.LoadGames();
        GameService.OnChange += StateHasChanged;
    }

    public void Dispose()
    {
        GameService.OnChange -= StateHasChanged;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoryService CategoryService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGameService GameService { get; set; }
    }
}
#pragma warning restore 1591
