using System.Collections.Generic;
using System.Linq;

using AlquilerAutos.App.Dominio;
using AlquilerAutos.App.Persistencia;

namespace AlquilerAutos.App.Persistencia.AppRepositorios
{
    public class RepositorioTipoCaja : IRepositorioTipoCaja
    {
        private readonly AppContext _appContext;

        public RepositorioTipoCaja(AppContext appContext)
        {
            _appContext = appContext;
        }
        //CRUD tipoCaja
        TipoCaja IRepositorioTipoCaja.AddTipoCaja(TipoCaja TipoCaja)
        {
            var TipoCajaAdicionado = _appContext.TiposCaja.Add(TipoCaja);

            _appContext.SaveChanges();

            return TipoCajaAdicionado.Entity;
        }

        TipoCaja IRepositorioTipoCaja.UpdateTipoCaja(TipoCaja tipoCaja)
        {
            var TipoCajaEncontrado = _appContext.TiposCaja.FirstOrDefault(p => p.id == tipoCaja.id);
            if (TipoCajaEncontrado != null)
            {
                TipoCajaEncontrado.marca = tipoCaja.marca;
                
                _appContext.SaveChanges();
            }
            return TipoCajaEncontrado;
        }
        void IRepositorioTipoCaja.DeleteTipoCaja(int idTipoCaja)
        {
            var TipoCajaEncontrado = _appContext.TiposCaja.FirstOrDefault(p => p.id == idTipoCaja);
            if (TipoCajaEncontrado == null)
                return;
            _appContext.TiposCaja.Remove(TipoCajaEncontrado);
            _appContext.SaveChanges();
        }
        TipoCaja IRepositorioTipoCaja.GetTipoCaja(int idTipoCaja)
        {
            return _appContext.TiposCaja.FirstOrDefault(p => p.id == idTipoCaja);
        }
        IEnumerable<TipoCaja> IRepositorioTipoCaja.GetAllTiposCaja()
        {
            return _appContext.TiposCaja;
        }
    }
}
