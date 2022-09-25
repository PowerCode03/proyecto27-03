using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;



namespace Proyecto.App.Dominio.Entidades
{
    public class Usuario
    {
        [Key]
        [Display(Name = "ID")]
        public int idUsuario {get;set;}
        [Required]        
        [Display(Name = "Nro. Identificación")]
        public string IdentificacionU {get; set;}
        [Required]        
        [Display(Name = "Primer Nombre")]
        public string PrimerNombreU {get;set;}
        [Required]        
        [Display(Name = "Segundo Nombre")]
        public string SegundoNombreU {get;set;}
        [Required]        
        [Display(Name = "Primer Apellido")]
        public string PrimerApellidoU {get;set;}
        [Required]        
        [Display(Name = "Segundo Apellido")]
        public string SegundoApellidoU {get;set;}
        [Required]        
        [Display(Name = "Telefono")]
        public string TelefonoU {get;set;}
        [Required]        
        [Display(Name = "Correo Electrónico")]
        public string EmailU {get;set;}
        [Required]        
        [Display(Name = "Direccion")]
        public string DireccionU {get;set;}
        
    }
}