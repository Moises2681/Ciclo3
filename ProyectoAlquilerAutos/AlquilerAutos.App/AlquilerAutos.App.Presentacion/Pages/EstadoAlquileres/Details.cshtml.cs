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
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioEstadoAlquiler _appContext;
        public EstadoAlquiler estadoAlquiler { get; set; }

        public DetailsModel()
        {
            this._appContext=new RepositorioEstadoAlquiler(new AlquilerAutos.App.Persistencia.AppRepositorios.AppContext());
        }

        //se ejecuta al presionar Detalle en la lista
        public IActionResult OnGet(int estadoAlquilerId)
        {
            estadoAlquiler = _appContext.GetEstadoAlquiler(estadoAlquilerId);
            if(estadoAlquiler == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }
    }
}