using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARRERASAPP.Entidades
{
    internal class Asignatura
    {
        public int Id_asignatura { get; set; }

        public string Nombre { get; set; }

        public Asignatura()
        {
            Id_asignatura = 0;
            Nombre=string.Empty;
        }

        public override string ToString()
        {
            return "Nombre de la asignatura" + Nombre;
        }
    }
}
