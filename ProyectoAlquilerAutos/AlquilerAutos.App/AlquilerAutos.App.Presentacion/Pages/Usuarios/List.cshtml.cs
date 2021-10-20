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

namespace AlquilerAutos.App.Presentacion.Pages.Usuarios
{
    public class ListModel : PageModel
    {
        private readonly IRepositorioUsuario _appContext;
        public IEnumerable<Usuario> usuarios {get; set;}         

        public ListModel()
        {
            this._appContext = new RepositorioUsuario(new AlquilerAutos.App.Persistencia.AppRepositorios.AppContext());
            
        }

        public void OnGet(string filtroBusqueda)
        {
            usuarios = _appContext.GetAllUsuarios();
        }
    }
}
