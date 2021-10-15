using System.Collections.Generic;
using System.Linq;

using AlquilerAutos.App.Dominio;
using AlquilerAutos.App.Persistencia;

namespace AlquilerAutos.App.Persistencia.AppRepositorios
{
    public class RepositorioAlquiler : IRepositorioAlquiler
    {
        private readonly AppContext _appContext;
        public RepositorioAlquiler(AppContext appContext)
        {
            _appContext = appContext;
        }
        //CRUD alquiler
        Alquiler IRepositorioAlquiler.AddAlquiler(Alquiler Alquiler)
        {
            var AlquilerAdicionado = _appContext.Alquileres.Add(Alquiler);

            _appContext.SaveChanges();

            return AlquilerAdicionado.Entity;
        }

        Alquiler IRepositorioAlquiler.UpdateAlquiler(Alquiler alquiler)
        {
            var AlquilerEncontrado = _appContext.Alquileres.FirstOrDefault(p => p.id == alquiler.id);
            if (AlquilerEncontrado != null)
            {
                AlquilerEncontrado.codigo = alquiler.codigo;
                AlquilerEncontrado.fechaInicio = alquiler.fechaInicio;
                AlquilerEncontrado.fechaFin = alquiler.fechaFin;
                AlquilerEncontrado.lugarRecogida = alquiler.lugarRecogida;
                AlquilerEncontrado.lugarEntrega = alquiler.lugarEntrega;
                AlquilerEncontrado.formaPago = alquiler.formaPago;
                AlquilerEncontrado.valorPagar = alquiler.valorPagar;

                _appContext.SaveChanges();
            }
            return AlquilerEncontrado;
        }
        void IRepositorioAlquiler.DeleteAlquiler(int idAlquiler)
        {
            var AlquilerEncontrado = _appContext.Alquileres.FirstOrDefault(p => p.id == idAlquiler);
            if (AlquilerEncontrado == null)
                return;
            _appContext.Alquileres.Remove(AlquilerEncontrado);
            _appContext.SaveChanges();
        }
        Alquiler IRepositorioAlquiler.GetAlquiler(int idAlquiler)
        {
            return _appContext.Alquileres.FirstOrDefault(p => p.id == idAlquiler);
        }
        IEnumerable<Alquiler> IRepositorioAlquiler.GetAllAlquileres()
        {
            return _appContext.Alquileres;
        }
    }
}