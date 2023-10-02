using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//agregamos esto:
using DepositoIndustrialApp.Servicios.Interfaz;

namespace DepositoIndustrialApp.Servicios
{
    public abstract class FabricaServicio
    {
        public abstract IServicio CrearServicio();
    }
}
