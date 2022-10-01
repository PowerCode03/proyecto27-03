using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyecto.App.Dominio.Entidades;

namespace Proyecto.App.Presentacion.Acudientes
{
    public class CrearModel : PageModel
    {
        [BindProperty]
        public  Acudiente acudiente { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {

        }
    }
}