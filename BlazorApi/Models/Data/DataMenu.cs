using Blazor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApi.Models.Data
{
    public class DataMenu
    {
        public List<MenuNav> GetMenu()
        {
            List<MenuNav> list = new List<MenuNav>();

            list.Add(new MenuNav { IdMenu = "1", PadreMenuId = "0", MenuName = "Home", IconName = "oi oi-home", SubMenuName = " "});
            list.Add(new MenuNav { IdMenu = "2", PadreMenuId = "0", MenuName = "Counter", IconName = "oi oi-plus", SubMenuName = "counter"});            
            list.Add(new MenuNav { IdMenu = "3", PadreMenuId = "0", MenuName = "Fetch Data", IconName = "oi oi-list-rich" , SubMenuName = "fetchdata" });
            list.Add(new MenuNav { IdMenu = "4", PadreMenuId = "0", MenuName = "Usuario", IconName = "oi oi-list-rich" , SubMenuName = "UsuarioInfo" });
            return list;
        }
    }
}
