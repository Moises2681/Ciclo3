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
    public class EditModel : PageModel
    {
        private readonly IRepositorioMarca _appContext;

        [BindProperty]
        public Marca marca { get; set; }
        public EditModel()
        {
            this._appContext = new RepositorioMarca(new AlquilerAutos.App.Persistencia.AppRepositorios.AppContext());
        }

        public IActionResult OnGet(int? marcaId)
        {
            if (marcaId.HasValue)
            {
                marca = _appContext.GetMarca(marcaId.Value);
            }
            else
            {
                marca = new Marca();
            }
            if (marca == null)
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
            if (marca.id > 0)
            {
                marca = _appContext.UpdateMarca(marca);
            }
            else
            {
                _appContext.AddMarca(marca);
            }
            return Page();
        }

    }
}
