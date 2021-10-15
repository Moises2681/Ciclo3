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
    public class EditModel : PageModel
    {
        private readonly IRepositorioUsuario _appContext;

        [BindProperty]
        public Usuario usuario { get; set; }
        public EditModel()
        {
            this._appContext = new RepositorioUsuario(new AlquilerAutos.App.Persistencia.AppRepositorios.AppContext());
        }

        public IActionResult OnGet(int? usuarioId)
        {
            if (usuarioId.HasValue)
            {
                usuario = _appContext.GetUsuario(usuarioId.Value);
            }
            else
            {
                usuario = new Usuario();
            }
            if (usuario == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (usuario.id > 0)
            {
                usuario = _appContext.UpdateUsuario(usuario);
            }
            else
            {
                _appContext.AddUsuario(usuario);
            }
            return Page();
        }

    }
}
