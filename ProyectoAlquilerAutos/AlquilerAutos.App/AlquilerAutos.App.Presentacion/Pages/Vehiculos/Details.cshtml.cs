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
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioVehiculo _appContext;
        public Vehiculo vehiculo { get; set; }

        public DetailsModel()
        {
            this._appContext=new RepositorioVehiculo(new AlquilerAutos.App.Persistencia.AppRepositorios.AppContext());
        }

        //se ejecuta al presionar Detalle en la lista
        public IActionResult OnGet(int vehiculoId)
        {
            vehiculo = _appContext.GetVehiculo(vehiculoId);
            if(vehiculo == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }
    }
}