using System;
using System.Collections.Generic;
using System.Linq;
using AlquilerAutos.App.Dominio;

namespace AlquilerAutos.App.Persistencia.AppRepositorios
{
    public interface IRepositorioTipoCombustible
    {
         // TipoCombustible
        TipoCombustible AddTipoCombustible(TipoCombustible tipoCombustible);
        IEnumerable<TipoCombustible> GetAllTiposCombustible();
        TipoCombustible GetTipoCombustible(int idTipoCombustible);
        TipoCombustible UpdateTipoCombustible(TipoCombustible tipoCombustible);
        void DeleteTipoCombustible(int idTipoCombustible);
    }
}