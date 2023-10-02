using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//

using DepositoIndustrialApp.Entidades;

namespace DepositoIndustrialApp.Servicios.Interfaz
{
    public interface IServicio
    {
       List<Material> TraerMateriales();//que se usa en el load del principal(metodo cargar material)

        bool CrearOrden(OrdenRetiro oOrden); 

    }
}
