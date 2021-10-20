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

namespace AlquilerAutos.App.Presentacion.Pages.Marcas
{
    public class ListModel : PageModel
    {
        private readonly IRepositorioMarca _appContext;
        public IEnumerable<Marca> marcas {get; set;}         

        public ListModel()
        {
            this._appContext = new RepositorioMarca(new AlquilerAutos.App.Persistencia.AppRepositorios.AppContext());
            
        }

        public void OnGet(string filtroBusqueda)
        {
            marcas = _appContext.GetAllMarca();
        }
    }
}
