using System.Collections.Generic;
using System.Linq;

using AlquilerAutos.App.Dominio;
using AlquilerAutos.App.Persistencia;

namespace AlquilerAutos.App.Persistencia.AppRepositorios
{
    public class RepositorioTipoCombustible : IRepositorioTipoCombustible
    {
        private readonly AppContext _appContext;

        public RepositorioTipoCombustible(AppContext appContext)
        {
            _appContext = appContext;
        }
        //CRUD tipoCombustible
        TipoCombustible IRepositorioTipoCombustible.AddTipoCombustible(TipoCombustible TipoCombustible)
        {
            var TipoCombustibleAdicionado = _appContext.TiposCombustible.Add(TipoCombustible);

            _appContext.SaveChanges();

            return TipoCombustibleAdicionado.Entity;
        }

        TipoCombustible IRepositorioTipoCombustible.UpdateTipoCombustible(TipoCombustible tipoCombustible)
        {
            var TipoCombustibleEncontrado = _appContext.TiposCombustible.FirstOrDefault(p => p.id == tipoCombustible.id);
            if (TipoCombustibleEncontrado != null)
            {
                TipoCombustibleEncontrado.combustible = tipoCombustible.combustible;
                
                _appContext.SaveChanges();
            }
            return TipoCombustibleEncontrado;
        }
        void IRepositorioTipoCombustible.DeleteTipoCombustible(int idTipoCombustible)
        {
            var TipoCombustibleEncontrado = _appContext.TiposCombustible.FirstOrDefault(p => p.id == idTipoCombustible);
            if (TipoCombustibleEncontrado == null)
                return;
            _appContext.TiposCombustible.Remove(TipoCombustibleEncontrado);
            _appContext.SaveChanges();
        }
        TipoCombustible IRepositorioTipoCombustible.GetTipoCombustible(int idTipoCombustible)
        {
            return _appContext.TiposCombustible.FirstOrDefault(p => p.id == idTipoCombustible);
        }
        IEnumerable<TipoCombustible> IRepositorioTipoCombustible.GetAllTiposCombustible()
        {
            return _appContext.TiposCombustible;
        }
    }
}
