using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using AlquilerAutos.App.Dominio;
using AlquilerAutos.App.Persistencia.AppRepositorios;

namespace AlquilerAutos.App.Presentacion.Pages.TipoCajas
{
    public class DeleteModel : PageModel
    {
       private readonly IRepositorioTipoCaja _appContext;

        [BindProperty]
        public TipoCaja tipoCaja  { get; set; } 

        public DeleteModel()
        {
            this._appContext  =new RepositorioTipoCaja(new AlquilerAutos.App.Persistencia.AppRepositorios.AppContext());
        }
    
        //se ejecuta al presionar Eliminar en la lista
        public IActionResult OnGet(int tipoCajaId)
        {
            tipoCaja = _appContext.GetTipoCaja(tipoCajaId);
            if(tipoCaja == null)
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
            if(tipoCaja.id > 0)
            {
               _appContext.DeleteTipoCaja(tipoCaja.id);
            }
            return Page();
        }
    }
}