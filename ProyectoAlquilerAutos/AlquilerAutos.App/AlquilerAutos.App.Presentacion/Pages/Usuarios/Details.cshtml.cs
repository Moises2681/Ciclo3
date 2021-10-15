using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using AlquilerAutos.App.Dominio;
using AlquilerAutos.App.Persistencia.AppRepositorios;

namespace AlquilerAutos.App.Presentacion.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioUsuario _appContext;
        public Usuario usuario { get; set; }

        public DetailsModel()
        {
            this._appContext=new RepositorioUsuario(new AlquilerAutos.App.Persistencia.AppRepositorios.AppContext());
        }

        //se ejecuta al presionar Detalle en la lista
        public IActionResult OnGet(int usuarioId)
        {
            usuario = _appContext.GetUsuario(usuarioId);
            if(usuario == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }
    }
}