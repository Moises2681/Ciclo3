using System.Collections.Generic;
using System.Linq;

using AlquilerAutos.App.Dominio;
using AlquilerAutos.App.Persistencia;

namespace AlquilerAutos.App.Persistencia.AppRepositorios
{
    public class RepositorioHojaVida : IRepositorioHojaVida
    {
        private readonly AppContext _appContext;

        public RepositorioHojaVida(AppContext appContext)
        {
            _appContext = appContext;
        }
        //CRUD hojaVida
        HojaVida IRepositorioHojaVida.AddHojaVida(HojaVida HojaVida)
        {
            var HojaVidaAdicionado = _appContext.HojasVida.Add(HojaVida);

            _appContext.SaveChanges();

            return HojaVidaAdicionado.Entity;
        }

        HojaVida IRepositorioHojaVida.UpdateHojaVida(HojaVida hojaVida)
        {
            var HojaVidaEncontrado = _appContext.HojasVida.FirstOrDefault(p => p.id == hojaVida.id);
            if (HojaVidaEncontrado != null)
            {
                HojaVidaEncontrado.codigo = hojaVida.codigo;
                HojaVidaEncontrado.fechaTecnomecanica = hojaVida.fechaTecnomecanica;
                HojaVidaEncontrado.fechaSoat = hojaVida.fechaSoat;
                
                _appContext.SaveChanges();
            }
            return HojaVidaEncontrado;
        }
        void IRepositorioHojaVida.DeleteHojaVida(int idHojaVida)
        {
            var HojaVidaEncontrado = _appContext.HojasVida.FirstOrDefault(p => p.id == idHojaVida);
            if (HojaVidaEncontrado == null)
                return;
            _appContext.HojasVida.Remove(HojaVidaEncontrado);
            _appContext.SaveChanges();
        }
        HojaVida IRepositorioHojaVida.GetHojaVida(int idHojaVida)
        {
            return _appContext.HojasVida.FirstOrDefault(p => p.id == idHojaVida);
        }
        IEnumerable<HojaVida> IRepositorioHojaVida.GetAllHojasVida()
        {
            return _appContext.HojasVida;
        }
    }
}

