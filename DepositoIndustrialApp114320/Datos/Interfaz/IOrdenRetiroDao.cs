using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using DepositoIndustrialApp.Datos.Interfaz;
using DepositoIndustrialApp.Entidades;

namespace DepositoIndustrialApp.Datos.Interfaz
{
    public interface IOrdenRetiroDao 
    {
        
        List<Material> ObtenerMateriales();//un dao de producto, traeme los productos

        bool Crear(OrdenRetiro oOrden);


    }
}
