using System;
using System.Collections.Generic;
using System.Linq;
using AlquilerAutos.App.Dominio;

namespace TipoCajaAutos.App.Persistencia.AppRepositorios
{
    public interface IRepositorioTipoCaja
    {
         // TipoCaja
        TipoCaja AddTipoCaja(TipoCaja tipoCaja);
        IEnumerable<TipoCaja> GetAllTipoCajas();
        TipoCaja GetTipoCaja(int idTipoCaja);
        TipoCaja UpdateTipoCaja(TipoCaja tipoCaja);
        void DeleteTipoCaja(int idTipoCaja);
    }
}