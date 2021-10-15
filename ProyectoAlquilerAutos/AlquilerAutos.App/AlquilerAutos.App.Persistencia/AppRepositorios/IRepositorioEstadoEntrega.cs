using System;
using System.Collections.Generic;
using System.Linq;
using AlquilerAutos.App.Dominio;

namespace AlquilerAutos.App.Persistencia.AppRepositorios
{
    public interface IRepositorioEstadoEntrega
    {
         // EstadoEntrega
        EstadoEntrega AddEstadoEntrega(EstadoEntrega estadoEntrega);
        IEnumerable<EstadoEntrega> GetAllEstadosEntrega();
        EstadoEntrega GetEstadoEntrega(int idEstadoEntrega);
        EstadoEntrega UpdateEstadoEntrega(EstadoEntrega estadoEntrega);
        void DeleteEstadoEntrega(int idEstadoEntrega);
    }
}