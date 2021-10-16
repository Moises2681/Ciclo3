using System;
using System.Collections.Generic;
using System.Linq;
using AlquilerAutos.App.Dominio;

namespace AlquilerAutos.App.Persistencia.AppRepositorios
{
    public interface IRepositorioHojaVida
    {
         // HojaVida
        HojaVida AddHojaVida(HojaVida hojaVida);
        IEnumerable<HojaVida> GetAllHojasVida();
        HojaVida GetHojaVida(int idHojaVida);
        HojaVida UpdateHojaVida(HojaVida hojaVida);
        void DeleteHojaVida(int idHojaVida);
    }
}