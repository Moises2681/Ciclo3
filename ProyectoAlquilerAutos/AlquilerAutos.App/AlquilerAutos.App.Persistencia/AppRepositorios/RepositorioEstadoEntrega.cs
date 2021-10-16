using System.Collections.Generic;
using System.Linq;

using AlquilerAutos.App.Dominio;
using AlquilerAutos.App.Persistencia;

namespace AlquilerAutos.App.Persistencia.AppRepositorios
{
    public class RepositorioEstadoEntrega : IRepositorioEstadoEntrega
    {
        private readonly AppContext _appContext;

        public RepositorioEstadoEntrega(AppContext appContext)
        {
            _appContext = appContext;
        }
        //CRUD estadoEntrega
        EstadoEntrega IRepositorioEstadoEntrega.AddEstadoEntrega(EstadoEntrega EstadoEntrega)
        {
            var EstadoEntregaAdicionado = _appContext.EstadosEntrega.Add(EstadoEntrega);

            _appContext.SaveChanges();

            return EstadoEntregaAdicionado.Entity;
        }

        EstadoEntrega IRepositorioEstadoEntrega.UpdateEstadoEntrega(EstadoEntrega estadoEntrega)
        {
            var EstadoEntregaEncontrado = _appContext.EstadosEntrega.FirstOrDefault(p => p.id == estadoEntrega.id);
            if (EstadoEntregaEncontrado != null)
            {
                EstadoEntregaEncontrado.estadoEntrega = estadoEntrega.estadoEntrega;
                
                _appContext.SaveChanges();
            }
            return EstadoEntregaEncontrado;
        }
        void IRepositorioEstadoEntrega.DeleteEstadoEntrega(int idEstadoEntrega)
        {
            var EstadoEntregaEncontrado = _appContext.EstadosEntrega.FirstOrDefault(p => p.id == idEstadoEntrega);
            if (EstadoEntregaEncontrado == null)
                return;
            _appContext.EstadosEntrega.Remove(EstadoEntregaEncontrado);
            _appContext.SaveChanges();
        }
        EstadoEntrega IRepositorioEstadoEntrega.GetEstadoEntrega(int idEstadoEntrega)
        {
            return _appContext.EstadosEntrega.FirstOrDefault(p => p.id == idEstadoEntrega);
        }
        IEnumerable<EstadoEntrega> IRepositorioEstadoEntrega.GetAllEstadosEntrega()
        {
            return _appContext.EstadosEntrega;
        }
    }
}
