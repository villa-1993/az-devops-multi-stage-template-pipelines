#pragma checksum "e:\Devops\Blazor_ManagedIdentity\ServerBlazorEF\Pages\FetchData copy.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ca0fd3a29e0349bdffec588ab1dfb58364e1d54"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ServerBlazorEF.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "e:\Devops\Blazor_ManagedIdentity\ServerBlazorEF\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "e:\Devops\Blazor_ManagedIdentity\ServerBlazorEF\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "e:\Devops\Blazor_ManagedIdentity\ServerBlazorEF\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "e:\Devops\Blazor_ManagedIdentity\ServerBlazorEF\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "e:\Devops\Blazor_ManagedIdentity\ServerBlazorEF\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "e:\Devops\Blazor_ManagedIdentity\ServerBlazorEF\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "e:\Devops\Blazor_ManagedIdentity\ServerBlazorEF\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "e:\Devops\Blazor_ManagedIdentity\ServerBlazorEF\_Imports.razor"
using ServerBlazorEF;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "e:\Devops\Blazor_ManagedIdentity\ServerBlazorEF\_Imports.razor"
using ServerBlazorEF.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "e:\Devops\Blazor_ManagedIdentity\ServerBlazorEF\Pages\FetchData copy.razor"
using ServerBlazorEF.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData_copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "e:\Devops\Blazor_ManagedIdentity\ServerBlazorEF\Pages\FetchData copy.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
