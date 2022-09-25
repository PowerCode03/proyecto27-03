using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;


using Proyecto.App.Dominio.Entidades;

namespace proyecto.App.Presentacion.Pages.Medicos
{
    public class ListModel : PageModel
    {
        public IEnumerable<Medico> Medicos { get; set; }
        public ListModel(){
            Medicos = new List<Medico>()
            {
                new Medico{ N_matriculaPro="102030", PrimerNombre="Jhon",SegundoNombre="Estiven",PrimerApellido="Alvarez" ,SegundoApellido="Toro",Consultorio="G302",Especialidad="Pediatria"},
                new Medico{ N_matriculaPro="456789", PrimerNombre="Alex",SegundoNombre="Nick",PrimerApellido="Torres" ,SegundoApellido="Casas",Consultorio="G305",Especialidad="fisioterapia"},
                new Medico{ N_matriculaPro="487532", PrimerNombre="Mario",SegundoNombre="Angel",PrimerApellido="Moreno" ,SegundoApellido="Sandia",Consultorio="G304",Especialidad="psicologia"},
                new Medico{ N_matriculaPro="952321", PrimerNombre="Juana",SegundoNombre="Lorena",PrimerApellido="Murillo" ,SegundoApellido="Rodriguez",Consultorio="G303",Especialidad="dermatologia"}
            };
        }

        public void OnGet()
        {
            Medicos = new List<Medico>()
            {
                new Medico{ N_matriculaPro="102030", PrimerNombre="Jhon",SegundoNombre="Estiven",PrimerApellido="Alvarez" ,SegundoApellido="Toro",Consultorio="G302",Especialidad="Pediatria"},
                new Medico{ N_matriculaPro="456789", PrimerNombre="Alex",SegundoNombre="Nick",PrimerApellido="Torres" ,SegundoApellido="Casas",Consultorio="G305",Especialidad="fisioterapia"},
                new Medico{ N_matriculaPro="487532", PrimerNombre="Mario",SegundoNombre="Angel",PrimerApellido="Moreno" ,SegundoApellido="Sandia",Consultorio="G304",Especialidad="psicologia"},
                new Medico{ N_matriculaPro="952321", PrimerNombre="Juana",SegundoNombre="Lorena",PrimerApellido="Murillo" ,SegundoApellido="Rodriguez",Consultorio="G303",Especialidad="dermatologia"} 
            };
        }
    }
}
