using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;


using Proyecto.App.Dominio.Entidades;

namespace proyecto.App.Presentacion.Pages.Acudientes
{
    public class ListModel : PageModel
    {
        public IEnumerable<Acudiente> Acudientes { get; set; }
        public ListModel(){
            Acudientes = new List<Acudiente>()
            {
                new Acudiente{ Codigo=112233, NombreCompleto="Juan Andres Murillo Rodriguez",Telefono="312567459",Direccion="calle 5 # 12 -102"},
                new Acudiente{ Codigo=112234, NombreCompleto="Maria Nicol  Moreno Sanchez",Telefono="312567434",Direccion="calle 5 # 26 -102"},
                new Acudiente{ Codigo=112235, NombreCompleto="Miguel Angel  Torres Casas",Telefono="312567422",Direccion="calle 34 # 15 - 165"},
                new Acudiente{ Codigo=112236, NombreCompleto="Lorena Andrea Alvarez Toro ",Telefono="312567411",Direccion="calle 12 # 12 -10"}
            };
        }

        public void OnGet()
        {
            Acudientes = new List<Acudiente>()
            {
                new Acudiente{ Codigo=112233, NombreCompleto="Juan Andres Murillo Rodriguez",Telefono="312567459",Direccion="calle 5 # 12 -102"},
                new Acudiente{ Codigo=112234, NombreCompleto="Maria Nicol  Moreno Sanchez",Telefono="312567434",Direccion="calle 5 # 26 -102"},
                new Acudiente{ Codigo=112235, NombreCompleto="Miguel Angel  Torres Casas",Telefono="312567422",Direccion="calle 34 # 15 - 165"},
                new Acudiente{ Codigo=112236, NombreCompleto="Lorena Andrea Alvarez Toro ",Telefono="312567411",Direccion="calle 12 # 12 -10"} 
            };
        }
    }
}
