using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARRERASAPP.Entidades
{
    internal class DetalleCarreras
    {
        public int AnioCursado { get; set; }
        public int Cuatrimestre { get; set; }
        public Asignatura Asignatura { get; set; }

        public DetalleCarreras()
        {
            AnioCursado = 0;
            Cuatrimestre = 0;
            Asignatura = new Asignatura();
        }

        public DetalleCarreras(int anioCursado, int cuatrimestre, Asignatura asignatura)
        {
            AnioCursado = anioCursado;
            Cuatrimestre = cuatrimestre;
            Asignatura = asignatura;
        }

        public override string ToString()
        {
            return "Año de Cursado " +AnioCursado +"Cuatrimestre "+Cuatrimestre+ "Asignatura "+Asignatura.ToString();
        }
    }
}
