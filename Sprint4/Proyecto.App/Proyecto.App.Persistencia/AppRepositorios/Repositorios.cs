using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;
using Proyecto.App.Dominio.Entidades;

namespace Proyecto.App.Persistencia.AppRepositorios
{
    public class Repositorios : IRepositorios
    {
       private readonly AppContext _appContext;
       public IEnumerable<Usuario> usuarios {get; set;} 
       //public IEnumerable<Tutor> tutores {get; set;} 
       //public IEnumerable<Estudiante> estudiantes {get; set;} 

       public Repositorios(AppContext appContext)
        {
            _appContext = appContext;
        }
        
        //AQUÍ CADA UNO DE LOS MÉTODOS DEL CRUD, REFERENCIADOS EN LA INTERFACE
        //SIGUIENTE DIAPOSITIVA

        Usuario IRepositorios.AddUsuario(Usuario usuario)
        {
        try
         {
            var UsuarioAdicionado = _appContext.usuario.Add( usuario );  //INSERT en la BD
            _appContext.SaveChanges();                  
            return UsuarioAdicionado.Entity;
          }catch
            {
                throw;
            }
        }

        IEnumerable<Usuario> IRepositorios.GetAllUsuarios(string? searchString)
        {
            if (searchString == null)
                usuarios = _appContext.usuario;
            else{
                //busca coincidencias entre los registros y la cadena enviada
                usuarios = _appContext.usuario.Where(s => s.IdentificacionU.Contains(searchString));   
                //busca solamente los que son exactamente igual a la cadena enviada 
                //formadores = _appContext.formador.Where(s => s.identificacion.Equals(searchString));    
            }
            return usuarios;
        }

       Usuario IRepositorios.GetUsuario(int? idUsuario)
       {
            return _appContext.usuario.FirstOrDefault(p => p.id == idUsuario);
       }

       Usuario IRepositorios.UpdateUsuario(Usuario usuario)
        {    
            var UsuarioEncontrado = _appContext.usuario.FirstOrDefault(p => p.id == usuario.id);
            if (UsuarioEncontrado != null)
            {
                UsuarioEncontrado.IdentificacionU  = usuario.IdentificacionU;
                UsuarioEncontrado.PrimerNombreU   = usuario.PrimerNombreU;
                UsuarioEncontrado.SegundoNombreU  = usuario.SegundoNombreU;
                 UsuarioEncontrado.PrimerApellidoU = usuario.PrimerApellidoU;
                UsuarioEncontrado.SegundoApellidoU  = usuario.SegundoApellidoU;
                UsuarioEncontrado.TelefonoU  = usuario.TelefonoU;
                UsuarioEncontrado.EmailU  = usuario.EmailU;
                UsuarioEncontrado.DireccionU  = usuario.DireccionU;
                _appContext.SaveChanges();
            }
            return UsuarioEncontrado;
        }

        void IRepositorios.DeleteUsuario(int idUsuario)
        {   
            var UsuarioEncontrado = _appContext.usuario.FirstOrDefault(p => p.id == idUsuario);
            if (UsuarioEncontrado != null){                
                _appContext.usuario.Remove(UsuarioEncontrado);
                _appContext.SaveChanges();
            }
            return;
        }

  

    } //fin repositorios
}