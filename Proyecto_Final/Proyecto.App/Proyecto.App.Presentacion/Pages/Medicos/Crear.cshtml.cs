using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyecto.App.Dominio.Entidades;

namespace Proyecto.App.Presentacion.Medicos
{
    public class CrearModel : PageModel
    {
        [BindProperty]
        public Medico medico { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {

        }
    }
}