using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARRERASAPP.Entidades
{
    internal class Carrera
    {
        public int Id_Carrera { get; set; }
        public string NombreTitulo { get; set; }
        public List<DetalleCarreras> DetallesCarrera { get; set; }

        public Carrera()
        {
            DetallesCarrera = new List<DetalleCarreras>();
        }

        public void AgregarDetalle(DetalleCarreras detalle)
        {
            DetallesCarrera.Add(detalle);
        }

        public void EliminarDetalle(int posicion)
        {
            DetallesCarrera.RemoveAt(posicion);
        }
        public override string ToString()
        {
            return "Nombre de Carrera" +NombreTitulo.ToString();
        }

    }
}
