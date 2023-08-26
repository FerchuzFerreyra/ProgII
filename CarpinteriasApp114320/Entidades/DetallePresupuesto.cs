using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriasApp.Entidades
{
     class DetallePresupuesto
    {
      

      

        public Producto Producto { get; set; }

        public double Cantidad { get; set; }

        public DetallePresupuesto(Producto p, int cant)
        {
            this.Producto = p;
            this.Cantidad = cant;
        }

        public double CalcularSubtotal()
        {
            return Cantidad * Producto.Precio;
        }
        

    }
}

