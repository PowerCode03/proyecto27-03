using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;



namespace Proyecto.App.Dominio.Entidades
{
    public class Acudiente

    {
        [Key]
        [Display(Name = "Codigo")]
        public int Codigo {get; set;}  

        [Display(Name = "Nombre Completo")]
        public string NombreCompleto{get;set;}
        [Required]        
               
        [Display(Name = "Telefono")]
        public string Telefono {get;set;}
        [Required]        
        [Display(Name = "Direccion")]
        public string Direccion {get;set;}
       

        }
        
    }
