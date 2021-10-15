using System;
using System.Collections.Generic;
using System.Linq;
using AlquilerAutos.App.Dominio;

namespace AlquilerAutos.App.Persistencia.AppRepositorios
{
    public interface IRepositorioFormaPago
    {
         // FormaPago
        FormaPago AddFormaPago(FormaPago formaPago);
        IEnumerable<FormaPago> GetAllFormasPago();
        FormaPago GetFormaPago(int idFormaPago);
        FormaPago UpdateFormaPago(FormaPago formaPago);
        void DeleteFormaPago(int idFormaPago);
    }
}