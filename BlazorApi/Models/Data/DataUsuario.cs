using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor.Model;

namespace BlazorApi.Models.Data
{
    public class DataUsuario
    {

        public List<Usuario> GetUsuario()
        {
            List<Usuario> listUse = new List<Usuario>();

            listUse.Add(new Usuario { Nombre = "Andres Felipe", Apellido = "Zabala Aranzalez", Edad = 26});
            listUse.Add(new Usuario { Nombre = "Hernan Dario", Apellido = "Trujillo", Edad = 26});

            return listUse;
        }
    }
}
