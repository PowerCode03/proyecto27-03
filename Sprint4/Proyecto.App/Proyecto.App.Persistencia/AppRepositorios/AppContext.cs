using System;
using Microsoft.EntityFrameworkCore;
using Proyecto.App.Dominio.Entidades;

namespace Proyecto.App.Persistencia
{    
    public class AppContext : DbContext
    {
       /* public AppContext  (DbContextOptions<AppContext> options) : base(options)
        { 
        }*/

        //poner aqui los modelos
        public DbSet<Usuario> usuario{get; set;}
        //public DbSet<Tutor> tutor{get; set;}
        //public DbSet<Estudiante> estudiante{get; set;}

        //crear el deContext
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            optionsBuilder
           .UseSqlServer("Server=localhost; user id=sa; password=123456; Initial Catalog=BDproyectocitas;");            
            }
        }      

    }
}