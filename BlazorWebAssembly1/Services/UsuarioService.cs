using Blazor.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorWebAssembly1.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly HttpClient http;

        //Constrcutor
        public UsuarioService(HttpClient _http) => http = _http;
        

        public async Task<IEnumerable<Usuario>> GetUsuarios()
        {
            var s = await http.GetStringAsync($"usuario");
            return JsonConvert.DeserializeObject<IEnumerable<Usuario>>(s);              
        }
    }
}
 