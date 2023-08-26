using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriasApp.Entidades
{
    internal class Presupuesto
    {
        public int PresupuestoNro { get; set; }

        public DateTime Fecha { get; set; }

        public string Cliente { get; set; }

        public double CostoMO { get; set; }

        public double Descuento { get; set; }

        public DateTime FechaBaja { get; set; }

        public List<DetallePresupuesto> Detalles { get; set; }

        public Presupuesto()
        {
            Detalles = new List<DetallePresupuesto>();
        }

        public void AgregarDetalle(DetallePresupuesto detalle)
        {
            Detalles.Add(detalle);//agrego detalles
        }

        public void QuitarDetalle(int posicion)
        {
            Detalles.RemoveAt(posicion); //remover la posicion que yo le doy
        }

        public double CalcularTotal()
        {
            double total = 0;

            foreach (DetallePresupuesto det in Detalles)
            {
                total += det.CalcularSubtotal();
            }
            //for (int i = 0; i < Detalles.Count; i++)
            //{
            //    total += Detalles[i].CalcularSubtotal();
            //}


            return total;
        }
    }

}

