// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ManagementCentral.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\NA21\azure\lektion-7\ManagementCentral\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\NA21\azure\lektion-7\ManagementCentral\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\NA21\azure\lektion-7\ManagementCentral\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\NA21\azure\lektion-7\ManagementCentral\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\NA21\azure\lektion-7\ManagementCentral\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\NA21\azure\lektion-7\ManagementCentral\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\NA21\azure\lektion-7\ManagementCentral\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\NA21\azure\lektion-7\ManagementCentral\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\NA21\azure\lektion-7\ManagementCentral\_Imports.razor"
using ManagementCentral;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\NA21\azure\lektion-7\ManagementCentral\_Imports.razor"
using ManagementCentral.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\NA21\azure\lektion-7\ManagementCentral\_Imports.razor"
using ManagementCentral.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "D:\NA21\azure\lektion-7\ManagementCentral\Pages\Index.razor"
          
        private IEnumerable<ListDeviceModel> devices = new List<ListDeviceModel>();
        private CreateDeviceModel createDeviceModel = new CreateDeviceModel();

        private async Task OnSubmit()
        {
            await client.PostAsJsonAsync("https://na21-fapp.azurewebsites.net/api/CreateDevice?code=7KTvXcTMYmaKquqR4rFPYIeMJnay3LrNXCflrnc/SFS/vfy1Fns1eA==", createDeviceModel);
            createDeviceModel = new CreateDeviceModel();
            await GetDevicesAsync();
        }

        private async Task GetDevicesAsync()
        {
            devices = await client.GetFromJsonAsync<IEnumerable<ListDeviceModel>>("https://na21-fapp.azurewebsites.net/api/GetDevices?code=xSMFWVdMiNaKVnRKUa3U6ahKHZ7ajwxRX8j4JuQGYM8X5Iq9zdOdFg==");
        }

        private async Task DeleteDeviceAsync(string id)
        {
            await client.DeleteAsync("https://na21-fapp.azurewebsites.net/api/DeleteDevice?code=pkhcYh99V8Y/oCK43ajDffPpMEk0lakbEojgJC9Ruf5EJTaqVHWuWw==&deviceid=" + id);
            await GetDevicesAsync();
        }


        protected override async Task OnInitializedAsync()
        {
            await GetDevicesAsync();
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
    }
}
#pragma warning restore 1591
