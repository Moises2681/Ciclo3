using System.Collections.Generic;
using System.Linq;

using AlquilerAutos.App.Dominio;
using AlquilerAutos.App.Persistencia;

namespace AlquilerAutos.App.Persistencia.AppRepositorios
{
    public class RepositorioVehiculo : IRepositorioVehiculo
    {
        private readonly AppContext _appContext;
        public RepositorioVehiculo(AppContext appContext)
        {
            _appContext = appContext;
        }

        //CRUD vehiculo
        Vehiculo IRepositorioVehiculo.AddVehiculo(Vehiculo Vehiculo)
        {
            var VehiculoAdicionado = _appContext.Vehiculos.Add(Vehiculo);

            _appContext.SaveChanges();

            return VehiculoAdicionado.Entity;
        }

        Vehiculo IRepositorioVehiculo.UpdateVehiculo(Vehiculo vehiculo)
        {
            var VehiculoEncontrado = _appContext.Vehiculos.FirstOrDefault(p => p.id == vehiculo.id);
            if (VehiculoEncontrado != null)
            {
                VehiculoEncontrado.placa = vehiculo.placa;
                VehiculoEncontrado.modelo = vehiculo.modelo;
                VehiculoEncontrado.capacidad = vehiculo.capacidad;
                VehiculoEncontrado.color = vehiculo.color;
                VehiculoEncontrado.imagen = vehiculo.imagen;
                
                _appContext.SaveChanges();
            }
            return VehiculoEncontrado;
        }
        void IRepositorioVehiculo.DeleteVehiculo(int idVehiculo)
        {
            var VehiculoEncontrado = _appContext.Vehiculos.FirstOrDefault(p => p.id == idVehiculo);
            if (VehiculoEncontrado == null)
                return;
            _appContext.Vehiculos.Remove(VehiculoEncontrado);
            _appContext.SaveChanges();
        }
        Vehiculo IRepositorioVehiculo.GetVehiculo(int idVehiculo)
        {
            return _appContext.Vehiculos.FirstOrDefault(p => p.id == idVehiculo);
        }
        IEnumerable<Vehiculo> IRepositorioVehiculo.GetAllVehiculos()
        {
            return _appContext.Vehiculos;
        }
    }
}