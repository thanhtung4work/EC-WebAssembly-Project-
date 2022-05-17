#pragma checksum "D:\Projects\Suchimu\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d974f52f3834c87914a4a7c0889ab6986664e1cc"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/{categoryUrl}")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "D:\Projects\Suchimu\Client\Pages\Index.razor"
 if (category != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, "Welcome to ");
            __builder.AddContent(2, 
#nullable restore
#line 10 "D:\Projects\Suchimu\Client\Pages\Index.razor"
                    category.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, " section!");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenComponent<Suchimu.Client.Pages.ListGames>(5);
            __builder.CloseComponent();
#nullable restore
#line 12 "D:\Projects\Suchimu\Client\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(6);
            __builder.AddAttribute(7, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(8, "<h1>Suchimu says hi!</h1>");
            }
            ));
            __builder.AddAttribute(9, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(10, "h1");
                __builder2.AddContent(11, "Welcome back, ");
                __builder2.AddContent(12, 
#nullable restore
#line 20 "D:\Projects\Suchimu\Client\Pages\Index.razor"
                               LocalStorage.GetItemAsString("username")

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(13, "!");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenComponent<Suchimu.Client.Pages.ListGames>(15);
            __builder.CloseComponent();
#nullable restore
#line 24 "D:\Projects\Suchimu\Client\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "D:\Projects\Suchimu\Client\Pages\Index.razor"
 
    [Parameter]
    public string CategoryUrl { get; set; }

    private Category category = null;

    protected override async Task OnParametersSetAsync()
    {
        await GameService.LoadGames(CategoryUrl);

        if (CategoryUrl != null)
        {
            category = CategoryService.Categories.FirstOrDefault(c => c.Url.ToLower().Equals(CategoryUrl.ToLower()));
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISyncLocalStorageService LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGameService GameService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoryService CategoryService { get; set; }
    }
}
#pragma warning restore 1591
