using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using AlquilerAutos.App.Dominio;
using AlquilerAutos.App.Persistencia.AppRepositorios;


namespace AlquilerAutos.App.Presentacion.Pages.EstadoAlquileres
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioEstadoAlquiler _appContext;

        [BindProperty]
        public EstadoAlquiler estadoAlquiler { get; set; }
        public EditModel()
        {
            this._appContext = new RepositorioEstadoAlquiler(new AlquilerAutos.App.Persistencia.AppRepositorios.AppContext());
        }

        public IActionResult OnGet(int? estadoAlquilerId)
        {
            if (estadoAlquilerId.HasValue)
            {
                estadoAlquiler = _appContext.GetEstadoAlquiler(estadoAlquilerId.Value);
            }
            else
            {
                estadoAlquiler = new EstadoAlquiler();
            }
            if (estadoAlquiler == null)
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
            if (estadoAlquiler.id > 0)
            {
                estadoAlquiler = _appContext.UpdateEstadoAlquiler(estadoAlquiler);
            }
            else
            {
                _appContext.AddEstadoAlquiler(estadoAlquiler);
            }
            return Page();
        }

    }
}
