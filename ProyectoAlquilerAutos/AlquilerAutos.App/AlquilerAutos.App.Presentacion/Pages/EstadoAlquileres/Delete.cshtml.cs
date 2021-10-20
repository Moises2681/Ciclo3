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
    public class DeleteModel : PageModel
    {
       private readonly IRepositorioEstadoAlquiler _appContext;

        [BindProperty]
        public EstadoAlquiler estadoAlquiler  { get; set; } 

        public DeleteModel()
        {
            this._appContext  =new RepositorioEstadoAlquiler(new AlquilerAutos.App.Persistencia.AppRepositorios.AppContext());
        }
    
        //se ejecuta al presionar Eliminar en la lista
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

        //se ejecuta al presionar Eliminar en el formulario 
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(estadoAlquiler.id > 0)
            {
               _appContext.DeleteEstadoAlquiler(estadoAlquiler.id);
            }
            return Page();
        }
    }
}