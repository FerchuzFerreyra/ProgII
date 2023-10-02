using DepositoIndustrialApp.Servicios.Implementacion;
using DepositoIndustrialApp.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DepositoIndustrialApp.Servicios
{
    public class FabricaServicioImp : FabricaServicio//primero heredar
    {
        public override IServicio CrearServicio()//luego crear el metodo
        {
            return new Servicio();
        }
    }
}
