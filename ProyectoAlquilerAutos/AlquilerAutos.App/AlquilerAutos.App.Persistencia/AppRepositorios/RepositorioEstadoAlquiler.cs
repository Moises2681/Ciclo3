using System.Collections.Generic;
using System.Linq;

using AlquilerAutos.App.Dominio;
using AlquilerAutos.App.Persistencia;

namespace AlquilerAutos.App.Persistencia.AppRepositorios
{
    public class RepositorioEstadoAlquiler : IRepositorioEstadoAlquiler
    {
        private readonly AppContext _appContext;

        public RepositorioEstadoAlquiler(AppContext appContext)
        {
            _appContext = appContext;
        }
        //CRUD estadoAlquiler
        EstadoAlquiler IRepositorioEstadoAlquiler.AddEstadoAlquiler(EstadoAlquiler EstadoAlquiler)
        {
            var EstadoAlquilerAdicionado = _appContext.EstadosAlquiler.Add(EstadoAlquiler);

            _appContext.SaveChanges();

            return EstadoAlquilerAdicionado.Entity;
        }

        EstadoAlquiler IRepositorioEstadoAlquiler.UpdateEstadoAlquiler(EstadoAlquiler estadoAlquiler)
        {
            var EstadoAlquilerEncontrado = _appContext.EstadosAlquiler.FirstOrDefault(p => p.id == estadoAlquiler.id);
            if (EstadoAlquilerEncontrado != null)
            {
                EstadoAlquilerEncontrado.estadoAlquiler = estadoAlquiler.estadoAlquiler;
                
                _appContext.SaveChanges();
            }
            return EstadoAlquilerEncontrado;
        }
        void IRepositorioEstadoAlquiler.DeleteEstadoAlquiler(int idEstadoAlquiler)
        {
            var EstadoAlquilerEncontrado = _appContext.EstadosAlquiler.FirstOrDefault(p => p.id == idEstadoAlquiler);
            if (EstadoAlquilerEncontrado == null)
                return;
            _appContext.EstadosAlquiler.Remove(EstadoAlquilerEncontrado);
            _appContext.SaveChanges();
        }
        EstadoAlquiler IRepositorioEstadoAlquiler.GetEstadoAlquiler(int idEstadoAlquiler)
        {
            return _appContext.EstadosAlquiler.FirstOrDefault(p => p.id == idEstadoAlquiler);
        }
        IEnumerable<EstadoAlquiler> IRepositorioEstadoAlquiler.GetAllEstadosAlquiler()
        {
            return _appContext.EstadosAlquiler;
        }
    }
}
