#pragma checksum "D:\NA21\azure\lektion-3\BlazorManagementCentral\Shared\DailyStats.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f58e34399b9c07917593f0f105d4d79ac0d37c55"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorManagementCentral.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\NA21\azure\lektion-3\BlazorManagementCentral\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\NA21\azure\lektion-3\BlazorManagementCentral\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\NA21\azure\lektion-3\BlazorManagementCentral\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\NA21\azure\lektion-3\BlazorManagementCentral\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\NA21\azure\lektion-3\BlazorManagementCentral\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\NA21\azure\lektion-3\BlazorManagementCentral\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\NA21\azure\lektion-3\BlazorManagementCentral\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\NA21\azure\lektion-3\BlazorManagementCentral\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\NA21\azure\lektion-3\BlazorManagementCentral\_Imports.razor"
using BlazorManagementCentral;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\NA21\azure\lektion-3\BlazorManagementCentral\_Imports.razor"
using BlazorManagementCentral.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\NA21\azure\lektion-3\BlazorManagementCentral\_Imports.razor"
using BlazorManagementCentral.Models;

#line default
#line hidden
#nullable disable
    public partial class DailyStats : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "statistics");
            __builder.AddAttribute(2, "class", "card shadow");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "content");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "d-flex align-items-center justify-content-between");
            __builder.OpenElement(7, "div");
            __builder.AddMarkupContent(8, "<div class=\"title\">Daily Stats</div>\r\n                ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "ingress text-sub");
            __builder.AddContent(11, 
#nullable restore
#line 7 "D:\NA21\azure\lektion-3\BlazorManagementCentral\Shared\DailyStats.razor"
                                               stats.TotalMessages

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, " messages sent");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "span");
            __builder.AddAttribute(15, "class", "sync-icon");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "D:\NA21\azure\lektion-3\BlazorManagementCentral\Shared\DailyStats.razor"
                                              async () => { await GetDailyStats(); }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(17, "<i class=\"fas fa-sync-alt\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "stats mt-4");
#nullable restore
#line 16 "D:\NA21\azure\lektion-3\BlazorManagementCentral\Shared\DailyStats.razor"
             if (stats != null)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "stat-list-item mb-3");
            __builder.AddMarkupContent(23, @"<div class=""stat-item""><div class=""icon d-flex align-items-center justify-content-center""><i class=""fas fa-microchip""></i></div>
                        <div><div class=""title"">Total Devices</div>
                            <div class=""ingress"">Number of total devices</div></div></div>
                    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "stat");
            __builder.AddContent(26, 
#nullable restore
#line 30 "D:\NA21\azure\lektion-3\BlazorManagementCentral\Shared\DailyStats.razor"
                         stats.TotalDevices

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "stat-list-item mb-3");
            __builder.AddMarkupContent(29, @"<div class=""stat-item""><div class=""icon d-flex align-items-center justify-content-center""><i class=""fas fa-microchip""></i></div>
                        <div><div class=""title"">New Devices</div>
                            <div class=""ingress"">Number of new devices</div></div></div>
                    ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "stat");
            __builder.AddContent(32, 
#nullable restore
#line 46 "D:\NA21\azure\lektion-3\BlazorManagementCentral\Shared\DailyStats.razor"
                         stats.TotalNewDevices

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "stat-list-item mb-3");
            __builder.AddMarkupContent(35, @"<div class=""stat-item""><div class=""icon d-flex align-items-center justify-content-center""><i class=""fas fa-microchip""></i></div>
                        <div><div class=""title"">C2D Count</div>
                            <div class=""ingress"">Cloud 2 Device messages</div></div></div>
                    ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "stat");
            __builder.AddContent(38, 
#nullable restore
#line 62 "D:\NA21\azure\lektion-3\BlazorManagementCentral\Shared\DailyStats.razor"
                         stats.TotalC2DCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 65 "D:\NA21\azure\lektion-3\BlazorManagementCentral\Shared\DailyStats.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(39, "<div class=\"d-flex justify-content-center align-items-center\"><div class=\"spinner-border\" role=\"status\"><span class=\"visually-hidden\">Loading...</span></div></div>");
#nullable restore
#line 73 "D:\NA21\azure\lektion-3\BlazorManagementCentral\Shared\DailyStats.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.AddMarkupContent(41, "<div class=\"footer\"><img src=\"images/yellow-line.jpg\" class=\"card-img-top\" alt=\"yellow-line\"></div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "D:\NA21\azure\lektion-3\BlazorManagementCentral\Shared\DailyStats.razor"
       
    private DailyStatsItem stats;

    private async Task GetDailyStats()
    {
        stats = new DailyStatsItem();
        stats = await client.GetFromJsonAsync<DailyStatsItem>("https://na21-fa.azurewebsites.net/api/mock/dailystats");
    }


    protected override async Task OnInitializedAsync()
    {
        await GetDailyStats();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
    }
}
#pragma warning restore 1591