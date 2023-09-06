using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaApp.Dominio
{
    internal class Mascota
    {
        public string Nombre { get; set; }
        public Atencion Atencion { get; set; }
        public Tipo Tipo { get; set; }
        public int Edad { get; set; }
        public List <Atencion> LstAtenciones { get; set; }

        public Mascota()
        {
            Edad = 0;
            Nombre = string.Empty;
            Tipo = new Tipo();
            Atencion = new Atencion();
            LstAtenciones = new List<Atencion>();
        }

        public Mascota(string nombre, int edad,Tipo tipo,Atencion atencion)
        {
            Nombre = nombre;
            Edad = edad;
            Tipo = tipo;
            Atencion = atencion;

        }
        public override string ToString()
        {
            return Nombre;
        }

    }
}
