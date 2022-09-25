using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;


using Proyecto.App.Dominio.Entidades;

namespace proyecto.App.Presentacion.Pages.Usuarios
{
    public class ListModel : PageModel
    {
        public IEnumerable<Usuario> Usuarios { get; set; }
        public ListModel(){
            Usuarios = new List<Usuario>()
            {
                new Usuario{idUsuario=1, IdentificacionU="102030", PrimerNombreU="Jhon",SegundoNombreU="Estiven",PrimerApellidoU="Alvarez" ,SegundoApellidoU="Toro",TelefonoU="tell",EmailU="Ejemplo123.@gmail.com",DireccionU="Cra 2#13-25"},
                new Usuario{idUsuario=2, IdentificacionU="456789", PrimerNombreU="Alex",SegundoNombreU="Nick",PrimerApellidoU="Torres" ,SegundoApellidoU="Casas",TelefonoU="tell",EmailU="Ejemplo123.@gmail.com",DireccionU="direci"},
                new Usuario{idUsuario=3, IdentificacionU="487532", PrimerNombreU="Mario",SegundoNombreU="Angel",PrimerApellidoU="Moreno" ,SegundoApellidoU="Sandia",TelefonoU="tell",EmailU="Ejemplo123.@gmail.com",DireccionU="Cra 2"},
                new Usuario{idUsuario=4, IdentificacionU="952321", PrimerNombreU="Juana",SegundoNombreU="Lorena",PrimerApellidoU="Murillo" ,SegundoApellidoU="Rodriguez",TelefonoU="tell",EmailU="Ejemplo123.@gmail.com",DireccionU="#13-25"}
            };
        }

        public void OnGet()
        {
            Usuarios = new List<Usuario>()
            {
                new Usuario{idUsuario=1, IdentificacionU="102030", PrimerNombreU="Jhon",SegundoNombreU="Estiven",PrimerApellidoU="Alvarez" ,SegundoApellidoU="Toro",TelefonoU="tell",EmailU="Ejemplo123.@gmail.com",DireccionU="Cra 2#13-25"},
                new Usuario{idUsuario=2, IdentificacionU="456789", PrimerNombreU="Alex",SegundoNombreU="Nick",PrimerApellidoU="Torres" ,SegundoApellidoU="Casas",TelefonoU="tell",EmailU="Ejemplo123.@gmail.com",DireccionU="direci"},
                new Usuario{idUsuario=3, IdentificacionU="487532", PrimerNombreU="Mario",SegundoNombreU="Angel",PrimerApellidoU="Moreno" ,SegundoApellidoU="Sandia",TelefonoU="tell",EmailU="Ejemplo123.@gmail.com",DireccionU="Cra 2"},
                new Usuario{idUsuario=4, IdentificacionU="952321", PrimerNombreU="Juana",SegundoNombreU="Lorena",PrimerApellidoU="Murillo" ,SegundoApellidoU="Rodriguez",TelefonoU="tell",EmailU="Ejemplo123.@gmail.com",DireccionU="#13-25"} 
            };
        }
    }
}
