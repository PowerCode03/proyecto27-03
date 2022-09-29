using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

using Proyecto.App.Dominio.Entidades;
using Proyecto.App.Persistencia.AppRepositorios;
using Proyecto.App.Persistencia;

namespace Proyecto.App.Presentacion.Pages.Usuarios
{
    //[Authorize]
    public class ListModel : PageModel
    {
        private readonly IRepositorios _appContext;
        public IEnumerable<Usuario> usuarios {get; set;} 
        public string searchString;          

        public ListModel()
        {
            this._appContext = new Repositorios(new Proyecto.App.Persistencia.AppContext());
        }
       
        public void OnGet()
        {
            usuarios = _appContext.GetAllUsuarios(searchString);
        }        

        public IActionResult OnPost(string? searchString)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            usuarios = _appContext.GetAllUsuarios(searchString);
            return Page();
        }
        
    }
}
