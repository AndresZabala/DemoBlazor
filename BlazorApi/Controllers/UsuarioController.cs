using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApi.Models;
using BlazorApi.Models.Response;
using BlazorApi.Models.Data;

namespace BlazorApi.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        public DataUsuario data = new DataUsuario();

        [HttpGet]
        public IActionResult Get()
        {            
            var res = data.GetUsuario();
            return Ok(res);
        }
    }
}
