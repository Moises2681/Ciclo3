using System;
using System.Collections.Generic;
using System.Linq;
using AlquilerAutos.App.Dominio;

namespace AlquilerAutos.App.Persistencia.AppRepositorios
{
    public interface IRepositorioTipoCaja
    {
         // TipoCaja
        TipoCaja AddTipoCaja(TipoCaja tipoCaja);
        IEnumerable<TipoCaja> GetAllTiposCaja();
        TipoCaja GetTipoCaja(int idTipoCaja);
        TipoCaja UpdateTipoCaja(TipoCaja tipoCaja);
        void DeleteTipoCaja(int idTipoCaja);
    }
}