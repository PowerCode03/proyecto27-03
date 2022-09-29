
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyecto.App.Dominio.Entidades;

namespace Proyecto.App.Presentacion.Acudientes
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Acudiente acudiente { get; set; }
        public void OnGet(int Codigo)
        {
            Acudiente acudiente =new Acudiente();

        }
        public async Task<ActionResult> Onpost()
        {
            if (ModelState.IsValid) {

                acudiente.Codigo = 112233;
               
                acudiente.NombreCompleto = "nombre temporal para traer";
               
                //guardar los cambios x dbcontext
                return RedirectToPage("List");
            }
            return RedirectToPage();
        }

    }
}
