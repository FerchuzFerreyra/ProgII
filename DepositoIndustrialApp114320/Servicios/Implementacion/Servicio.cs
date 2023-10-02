using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DepositoIndustrialApp.Datos.Implementacion;
using DepositoIndustrialApp.Datos.Interfaz;
using DepositoIndustrialApp.Entidades;
using DepositoIndustrialApp.Servicios.Interfaz;

namespace DepositoIndustrialApp.Servicios.Implementacion
{
    public class Servicio : IServicio
    {
        private IOrdenRetiroDao dao;

        public Servicio()
        {
            dao = new OrdenRetiroDao();
        }

        public bool CrearOrden(OrdenRetiro oOrden)
        {
            return dao.Crear(oOrden);//lo traigo de interfaz servicio y
                                     //retorno el metodo crear que voy a implementar en el dao
        }

        public List<Material> TraerMateriales()//lo traigo de interfaz servicio y
                                               //retorno el metodo obtener materiales que voy a implementar en el dao
        {
            return dao.ObtenerMateriales();
        }
    }
}
