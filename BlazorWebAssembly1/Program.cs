using BlazorWebAssembly1.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebAssembly1
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            //La BaseAddres es el entorno donde esta apuntando la aplicacion
            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });           
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:44334/api/") });
            //Se agregan los servicios
            builder.Services.AddScoped<IUsuarioService, UsuarioService>();

            await builder.Build().RunAsync();
        }
    }
}
