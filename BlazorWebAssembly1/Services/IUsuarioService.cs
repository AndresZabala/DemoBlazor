using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor.Model;

namespace BlazorWebAssembly1.Services
{
    interface IUsuarioService
    {
        Task<IEnumerable<Usuario>> GetUsuarios();
    }
}
