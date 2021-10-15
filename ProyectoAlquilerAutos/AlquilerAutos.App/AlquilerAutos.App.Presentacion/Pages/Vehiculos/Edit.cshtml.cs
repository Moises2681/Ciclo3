using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using AlquilerAutos.App.Dominio;
using AlquilerAutos.App.Persistencia.AppRepositorios;


namespace AlquilerAutos.App.Presentacion.Pages.Vehiculos
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioVehiculo _appContext;

        [BindProperty]
        	public Vehiculo vehiculo { get; set; }
        public EditModel()
        {
            this._appContext = new RepositorioVehiculo(new AlquilerAutos.App.Persistencia.AppRepositorios.AppContext());
        }

        public IActionResult OnGet(int? vehiculoId)
        {
            if (vehiculoId.HasValue)
            {
                vehiculo = _appContext.GetVehiculo(vehiculoId.Value);
            }
            else
            {
                vehiculo = new Vehiculo();
            }
            if (vehiculo == null)
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
            if (vehiculo.id > 0)
            {
                vehiculo = _appContext.UpdateVehiculo(vehiculo);
            }
            else
            {
                _appContext.AddVehiculo(vehiculo);
            }
            return Page();
        }

    }
}
