using System;
using System.Collections.Generic;
using System.Linq;
using AlquilerAutos.App.Dominio;

namespace AlquilerAutos.App.Persistencia.AppRepositorios
{
    public interface IRepositorioUsuario
    {
        // Usuario
        Usuario AddUsuario(Usuario usuario);
        IEnumerable<Usuario> GetAllUsuarios();
        Usuario GetUsuario(int idUsuario);
        Usuario UpdateUsuario(Usuario usuario);
        void DeleteUsuario(int idUsuario);
    }
}