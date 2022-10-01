//Directivas
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;
using Proyecto.App.Dominio.Entidades;
using Proyecto.App.Persistencia.AppRepositorios;

namespace Proyecto.App.Persistencia.AppRepositorios
{
    public interface IRepositorios
    {
        //contratos o firmas para los metodos Formador        
        Usuario AddUsuario(Usuario usuario);
        IEnumerable<Usuario> GetAllUsuarios(string? searchString);         
        Usuario GetUsuario(int? idUsuario);
        Usuario UpdateUsuario(Usuario usuario);
        void DeleteUsuario(int idUsuario); 

        
    

    } //fin IRepositorios
}
