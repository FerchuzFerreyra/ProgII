using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositoIndustrialApp.Entidades
{
    public class OrdenRetiro
    {
        public int OrdenRetiroNro { get; set; }
        public DateTime Fecha { get; set; }
        public string Responsable { get; set; }

        public List<DetalleOrden> Detalles { get; set; }

        public OrdenRetiro()//se instancia en el constructor
        {
            Detalles = new List<DetalleOrden>();//se usa para la grilla
        }

        public void AgregarDetalle(DetalleOrden detalle)
        {
            Detalles.Add(detalle);
        }
        public void QuitarDetalle(int posicion)//se programa en la grilla
        {
            Detalles.RemoveAt(posicion);
        }
    }


}
