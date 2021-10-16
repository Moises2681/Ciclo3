using System;
using System.Collections.Generic;
using System.Linq;
using AlquilerAutos.App.Dominio;

namespace AlquilerAutos.App.Persistencia.AppRepositorios
{
    public interface IRepositorioEstadoAlquiler
    {
         // EstadoAlquiler
        EstadoAlquiler AddEstadoAlquiler(EstadoAlquiler estadoAlquiler);
        IEnumerable<EstadoAlquiler> GetAllEstadosAlquiler();
        EstadoAlquiler GetEstadoAlquiler(int idEstadoAlquiler);
        EstadoAlquiler UpdateEstadoAlquiler(EstadoAlquiler estadoAlquiler);
        void DeleteEstadoAlquiler(int idEstadoAlquiler);
    }
}