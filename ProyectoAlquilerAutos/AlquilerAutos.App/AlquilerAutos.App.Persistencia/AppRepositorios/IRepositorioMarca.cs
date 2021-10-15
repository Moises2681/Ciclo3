using System;
using System.Collections.Generic;
using System.Linq;
using MarcaAutos.App.Dominio;

namespace MarcaAutos.App.Persistencia.AppRepositorios
{
    public interface IRepositorioMarca
    {
         // Marca
        Marca AddMarca(Marca marca);
        IEnumerable<Marca> GetAllMarcas();
        Marca GetMarca(int idMarca);
        Marca UpdateMarca(Marca marca);
        void DeleteMarca(int idMarca);
    }
}