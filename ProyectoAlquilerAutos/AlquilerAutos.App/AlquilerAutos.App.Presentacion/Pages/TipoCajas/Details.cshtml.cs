using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using AlquilerAutos.App.Dominio;
using AlquilerAutos.App.Persistencia.AppRepositorios;

namespace AlquilerAutos.App.Presentacion.Pages.TipoCajas
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioTipoCaja _appContext;
        public TipoCaja tipoCaja { get; set; }

        public DetailsModel()
        {
            this._appContext=new RepositorioTipoCaja(new AlquilerAutos.App.Persistencia.AppRepositorios.AppContext());
        }

        //se ejecuta al presionar Detalle en la lista
        public IActionResult OnGet(int tipoCajaId)
        {
            tipoCaja = _appContext.GetTipoCaja(tipoCajaId);
            if(tipoCaja == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }
    }
}