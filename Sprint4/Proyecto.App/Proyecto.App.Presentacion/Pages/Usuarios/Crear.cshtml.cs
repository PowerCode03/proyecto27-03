using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyecto.App.Dominio.Entidades;
using Proyecto.App.Persistencia.AppRepositorios;
using Proyecto.App.Persistencia;

namespace Proyecto.App.Presentacion.Usuarios
{
    public class CrearModel : PageModel
    {
        private readonly IRepositorios _appContext;
        [BindProperty]
        public Usuario usuario { get; set; }

        public CrearModel(){
            //cargar desde la base de datos tabla formador
            this._appContext = new Repositorios(new Proyecto.App.Persistencia.AppContext());
            //cargarTemporales();
        }
       

        public IActionResult OnGet(int? usuarioId)
        {
            if (usuarioId.HasValue)
            {
                usuario = _appContext.GetUsuario(usuarioId.Value);
            }
            else
            {
                usuario = new Usuario();
            }
            if (usuario == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(usuario.id > 0)
            {
               usuario = _appContext.UpdateUsuario(usuario);
            }
            else
            {
                //formador.vigente = true;
               _appContext.AddUsuario(usuario);
            }
            return Redirect("List");
            
        }
    }
}

