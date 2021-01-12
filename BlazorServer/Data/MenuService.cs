using Blazor.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorServer.Data
{
    public class MenuService
    {
        List<MenuNav> listMenu = new List<MenuNav>();

        public HttpClient http = new HttpClient();

        public async Task<IEnumerable<MenuNav>> GetMenuService()
        {
            try
            {
                var a = await http.GetStringAsync("https://localhost:44334/api/Menu");
                return listMenu = JsonConvert.DeserializeObject<List<MenuNav>>(a);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return listMenu;
            }                    
        }       
    }
}
