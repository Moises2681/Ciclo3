using System;
using System.Collections.Generic;
using System.Linq;
using TipoCombustibleAutos.App.Dominio;

namespace TipoCombustibleAutos.App.Persistencia.AppRepositorios
{
    public interface IRepositorioTipoCombustible
    {
         // TipoCombustible
        TipoCombustible AddTipoCombustible(TipoCombustible tipoCombustible);
        IEnumerable<TipoCombustible> GetAllTipoCombustibles();
        TipoCombustible GetTipoCombustible(int idTipoCombustible);
        TipoCombustible UpdateTipoCombustible(TipoCombustible tipoCombustible);
        void DeleteTipoCombustible(int idTipoCombustible);
    }
}