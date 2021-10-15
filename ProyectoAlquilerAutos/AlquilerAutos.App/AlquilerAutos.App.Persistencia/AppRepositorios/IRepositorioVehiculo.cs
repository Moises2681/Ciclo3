using System;
using System.Collections.Generic;
using System.Linq;
using AlquilerAutos.App.Dominio;

namespace AlquilerAutos.App.Persistencia.AppRepositorios
{
    public interface IRepositorioVehiculo
    {
         // Vehiculo
        Vehiculo AddVehiculo(Vehiculo vehiculo);
        IEnumerable<Vehiculo> GetAllVehiculos();
        Vehiculo GetVehiculo(int idVehiculo);
        Vehiculo UpdateVehiculo(Vehiculo vehiculo);
        void DeleteVehiculo(int idVehiculo);
    }
}