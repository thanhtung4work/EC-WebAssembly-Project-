#pragma checksum "D:\Projects\Suchimu\Client\Pages\ListStudios.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ed68b4de525cc8df6750bcd0aa687c72e0a5492"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/studio/all")]
    public partial class ListStudios : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>From our studio</h3>\r\n<div class></div>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row mb-3");
#nullable restore
#line 7 "D:\Projects\Suchimu\Client\Pages\ListStudios.razor"
     foreach (var studio in StudioService.Studios)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(3);
            __builder.AddAttribute(4, "class", "col-5 p-1 mt-4");
            __builder.AddAttribute(5, "href", 
#nullable restore
#line 9 "D:\Projects\Suchimu\Client\Pages\ListStudios.razor"
                                               GetUrl(studio.Url)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "btn btn-primary ronunded mx-1");
                __builder2.OpenElement(9, "p");
                __builder2.AddAttribute(10, "style", "text-align: center");
                __builder2.AddContent(11, 
#nullable restore
#line 11 "D:\Projects\Suchimu\Client\Pages\ListStudios.razor"
                                               studio.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(12, "\r\n                ");
                __builder2.OpenElement(13, "img");
                __builder2.AddAttribute(14, "src", 
#nullable restore
#line 12 "D:\Projects\Suchimu\Client\Pages\ListStudios.razor"
                           studio.ImageUrl

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(15, "style", "width: 100%");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\r\n        <div class=\"col-1\"></div>");
#nullable restore
#line 17 "D:\Projects\Suchimu\Client\Pages\ListStudios.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "D:\Projects\Suchimu\Client\Pages\ListStudios.razor"
       
    protected override async Task OnInitializedAsync()
    {
        await StudioService.LoadStudios();
    }

    private string GetUrl(String url)
    {
        return "studio/" + url;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStudioService StudioService { get; set; }
    }
}
#pragma warning restore 1591