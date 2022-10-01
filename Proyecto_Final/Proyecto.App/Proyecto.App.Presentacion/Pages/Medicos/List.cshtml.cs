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
                new Medico{ N_matriculaPro=102030, NombreCompleto="Jhon Jairo Alvarez Toro",Consultorio="G302",Especialidad="Pediatria"},
                new Medico{ N_matriculaPro=456789, NombreCompleto="Alex Nick Torres Casas",Consultorio="G305",Especialidad="fisioterapia"},
                new Medico{ N_matriculaPro=487532, NombreCompleto="Mario Angel Moreno Sanchez",Consultorio="G304",Especialidad="psicologia"},
                new Medico{ N_matriculaPro=952321, NombreCompleto="Juana Lorena Murillo Rodriguez",Consultorio="G303",Especialidad="dermatologia"}
            };
        }

        public void OnGet()
        {
            Medicos = new List<Medico>()
            {
                new Medico{ N_matriculaPro=102030, NombreCompleto="Jhon Jairo Alvarez Toro",Consultorio="G302",Especialidad="Pediatria"},
                new Medico{ N_matriculaPro=456789, NombreCompleto="Alex Nick Torres Casas",Consultorio="G305",Especialidad="fisioterapia"},
                new Medico{ N_matriculaPro=487532, NombreCompleto="Mario Angel Moreno Sanchez",Consultorio="G304",Especialidad="psicologia"},
                new Medico{ N_matriculaPro=952321, NombreCompleto="Juana Lorena Murillo Rodriguez",Consultorio="G303",Especialidad="dermatologia"} 
            };
        }
    }
}
