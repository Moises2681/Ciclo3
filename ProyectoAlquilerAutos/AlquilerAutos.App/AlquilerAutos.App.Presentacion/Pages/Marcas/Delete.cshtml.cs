using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using AlquilerAutos.App.Dominio;
using AlquilerAutos.App.Persistencia.AppRepositorios;

namespace AlquilerAutos.App.Presentacion.Pages.marcas
{
    public class DeleteModel : PageModel
    {
       private readonly IRepositorioMarca _appContext;

        [BindProperty]
        public Marca marca { get; set; } 

        public DeleteModel()
        {
            this._appContext  =new RepositorioMarca(new AlquilerAutos.App.Persistencia.AppRepositorios.AppContext());
        }
    
        //se ejecuta al presionar Eliminar en la lista
        public IActionResult OnGet(int marca)
        {
            marca = _appContext.GetMarca(marcaId);
            if(marca == null)
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
            if(marca.id > 0)
            {
               _appContext.DeleteMarca(marca.id);
            }
            return Page();
        }
    }
}