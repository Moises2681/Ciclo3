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

namespace AlquilerAutos.App.Presentacion.Pages.EstadoAlquileres
{
    public class ListModel : PageModel
    {
        private readonly IRepositorioEstadoAlquiler _appContext;
        public IEnumerable<EstadoAlquiler> estadoAlquileres {get; set;}         

        public ListModel()
        {
            this._appContext = new RepositorioEstadoAlquiler(new AlquilerAutos.App.Persistencia.AppRepositorios.AppContext());
            
        }

        public void OnGet(string filtroBusqueda)
        {
            estadoAlquileres = _appContext.GetAllEstadoAlquiler();
        }
    }
}
