using System;
using System.Collections.Generic;
using System.Linq;
using AlquilerAutos.App.Dominio;

namespace AlquilerAutos.App.Persistencia.AppRepositorios
{
    public interface IRepositorioEstadoAlquiler
    {
         // Alquiler
        EstadoAlquiler AddEstadoAlquiler(EstadoAlquiler estadoAlquiler);
        IEnumerable<EstadoAlquiler> GetAllEstadoAlquileres();
        Alquiler GetAlquiler(int idAlquiler);
        Alquiler UpdateAlquiler(Alquiler alquiler);
        void DeleteAlquiler(int idAlquiler);
    }
}