using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;



namespace Proyecto.App.Dominio.Entidades
{
    public class Medico
    {
        [Key]
        [Display(Name = "N_matriculaPro")]
        public string N_matriculaPro {get; set;}       
        [Display(Name = "Primer Nombre")]
        public string PrimerNombre {get;set;}
        [Required]        
        [Display(Name = "Segundo Nombre")]
        public string SegundoNombre {get;set;}
        [Required]        
        [Display(Name = "Primer Apellido")]
        public string PrimerApellido {get;set;}
        [Required]        
        [Display(Name = "Segundo Apellido")]
        public string SegundoApellido {get;set;}
        [Required]        
        [Display(Name = "Consultorio")]
        public string Consultorio {get;set;}
        [Required]        
        [Display(Name = "Especialidad")]
        public string Especialidad {get;set;}
       

        }
        
    }
