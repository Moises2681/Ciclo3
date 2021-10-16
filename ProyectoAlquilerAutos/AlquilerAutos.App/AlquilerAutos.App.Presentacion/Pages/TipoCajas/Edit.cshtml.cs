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
    public class EditModel : PageModel
    {
        private readonly IRepositorioTipoCaja _appContext;

        [BindProperty]
        public TipoCaja tipoCaja { get; set; }
        public EditModel()
        {
            this._appContext = new RepositorioTipoCaja(new AlquilerAutos.App.Persistencia.AppRepositorios.AppContext());
        }

        public IActionResult OnGet(int? tipoCajaId)
        {
            if (tipoCajaId.HasValue)
            {
                tipoCaja = _appContext.GetTipoCaja(tipoCajaId.Value);
            }
            else
            {
                tipoCaja = new TipoCaja();
            }
            if (tipoCaja == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (tipoCaja.id > 0)
            {
                tipoCaja = _appContext.UpdateTipoCaja(tipoCaja);
            }
            else
            {
                _appContext.AddTipoCaja(tipoCaja);
            }
            return Page();
        }

    }
}
