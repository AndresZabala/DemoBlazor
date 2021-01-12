using Blazor.Model;
using BlazorApi.Models.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApi.Controllers
{    
    [Route("api/[controller]")]
    public class MenuController : ControllerBase
    {
        public DataMenu dataMenu = new DataMenu();


        [HttpGet]
        public IActionResult Get()
        {
            var a = dataMenu.GetMenu();
            return Ok(a);
        }
    }
}
