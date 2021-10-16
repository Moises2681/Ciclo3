using System.Collections.Generic;
using System.Linq;

using AlquilerAutos.App.Dominio;
using AlquilerAutos.App.Persistencia;

namespace AlquilerAutos.App.Persistencia.AppRepositorios
{
    public class RepositorioFormaPago : IRepositorioFormaPago
    {
        private readonly AppContext _appContext;

        public RepositorioFormaPago(AppContext appContext)
        {
            _appContext = appContext;
        }
        //CRUD formaPago
        FormaPago IRepositorioFormaPago.AddFormaPago(FormaPago FormaPago)
        {
            var FormaPagoAdicionado = _appContext.FormasPago.Add(FormaPago);

            _appContext.SaveChanges();

            return FormaPagoAdicionado.Entity;
        }

        FormaPago IRepositorioFormaPago.UpdateFormaPago(FormaPago formaPago)
        {
            var FormaPagoEncontrado = _appContext.FormasPago.FirstOrDefault(p => p.id == formaPago.id);
            if (FormaPagoEncontrado != null)
            {
                FormaPagoEncontrado.nombre = formaPago.nombre;
                
                _appContext.SaveChanges();
            }
            return FormaPagoEncontrado;
        }
        void IRepositorioFormaPago.DeleteFormaPago(int idFormaPago)
        {
            var FormaPagoEncontrado = _appContext.FormasPago.FirstOrDefault(p => p.id == idFormaPago);
            if (FormaPagoEncontrado == null)
                return;
            _appContext.FormasPago.Remove(FormaPagoEncontrado);
            _appContext.SaveChanges();
        }
        FormaPago IRepositorioFormaPago.GetFormaPago(int idFormaPago)
        {
            return _appContext.FormasPago.FirstOrDefault(p => p.id == idFormaPago);
        }
        IEnumerable<FormaPago> IRepositorioFormaPago.GetAllFormasPago()
        {
            return _appContext.FormasPago;
        }
    }
}
