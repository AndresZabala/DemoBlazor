// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\andres.zabala\source\repos\ProyectBlazor\BlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\andres.zabala\source\repos\ProyectBlazor\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\andres.zabala\source\repos\ProyectBlazor\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\andres.zabala\source\repos\ProyectBlazor\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\andres.zabala\source\repos\ProyectBlazor\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\andres.zabala\source\repos\ProyectBlazor\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\andres.zabala\source\repos\ProyectBlazor\BlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\andres.zabala\source\repos\ProyectBlazor\BlazorServer\_Imports.razor"
using BlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\andres.zabala\source\repos\ProyectBlazor\BlazorServer\_Imports.razor"
using BlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\andres.zabala\source\repos\ProyectBlazor\BlazorServer\Pages\UsuarioInfo.razor"
using BlazorApi.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\andres.zabala\source\repos\ProyectBlazor\BlazorServer\Pages\UsuarioInfo.razor"
using Blazor.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\andres.zabala\source\repos\ProyectBlazor\BlazorServer\Pages\UsuarioInfo.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/UsuarioInfo")]
    public partial class UsuarioInfo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\andres.zabala\source\repos\ProyectBlazor\BlazorServer\Pages\UsuarioInfo.razor"
      
    List<Usuario> listUse = new List<Usuario>();
    private async Task GetUsuario()
    {
        try
        {
            var d = await http.GetStringAsync("https://localhost:44334/api/usuario");
            listUse = JsonConvert.DeserializeObject<List<Usuario>>(d);
        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
