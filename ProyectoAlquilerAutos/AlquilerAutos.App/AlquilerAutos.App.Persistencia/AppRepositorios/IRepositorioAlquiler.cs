using System;
using System.Collections.Generic;
using System.Linq;
using AlquilerAutos.App.Dominio;

namespace AlquilerAutos.App.Persistencia.AppRepositorios
{
    public interface IRepositorioAlquiler
    {
         // Alquiler
        Alquiler AddAlquiler(Alquiler alquiler);
        IEnumerable<Alquiler> GetAllAlquileres();
        Alquiler GetAlquiler(int idAlquiler);
        Alquiler UpdateAlquiler(Alquiler alquiler);
        void DeleteAlquiler(int idAlquiler);
    }
}