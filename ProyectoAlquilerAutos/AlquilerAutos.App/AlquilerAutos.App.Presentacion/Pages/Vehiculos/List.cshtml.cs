using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

using AlquilerAutos.App.Dominio;
using AlquilerAutos.App.Persistencia.AppRepositorios;
using AlquilerAutos.App.Persistencia;

namespace AlquilerAutos.App.Presentacion.Pages.Vehiculos
{
    public class ListModel : PageModel
    {
        private readonly IRepositorioVehiculo _appContext;
        public IEnumerable<Vehiculo> vehiculos {get; set;}         

        public ListModel()
        {
            this._appContext = new RepositorioVehiculo(new AlquilerAutos.App.Persistencia.AppRepositorios.AppContext());
            
        }

        public void OnGet(string filtroBusqueda)
        {
            vehiculos = _appContext.GetAllVehiculos();
        }
    }
}
