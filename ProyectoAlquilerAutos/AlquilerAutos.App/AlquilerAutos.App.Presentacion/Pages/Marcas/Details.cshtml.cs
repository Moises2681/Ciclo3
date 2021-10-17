using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using AlquilerAutos.App.Dominio;
using AlquilerAutos.App.Persistencia.AppRepositorios;

namespace AlquilerAutos.App.Presentacion.Pages.Marcas
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioMarca _appContext;
        public Marca marca { get; set; }

        public DetailsModel()
        {
            this._appContext=new RepositorioMarca(new AlquilerAutos.App.Persistencia.AppRepositorios.AppContext());
        }

        //se ejecuta al presionar Detalle en la lista
        public IActionResult OnGet(int marcaId)
        {
            marca = _appContext.GetMarca(marcaId);
            if(marca == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }
    }
}