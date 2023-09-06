using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaApp.Dominio
{
    internal class Tipo
    {

        public string Nombre { get; set; }
        public Tipo()
        {
            Nombre = string.Empty;     
        }
        public Tipo(string nombre)
        {
            Nombre=nombre;
                
        }
    }
}
