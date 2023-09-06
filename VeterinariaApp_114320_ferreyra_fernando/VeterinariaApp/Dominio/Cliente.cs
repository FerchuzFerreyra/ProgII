using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaApp.Dominio
{
    internal class Cliente
    {

        public string  Nombre{ get; set; }
        public bool Sexo { get; set; }
        public int Codigo{ get; set; }
        public Mascota Mascota { get; set; }
        public List <Mascota> LstMascota { get; set; }

        public Cliente()
        {
            Nombre = string.Empty;
            Sexo = false;
            Codigo = 0;
            Mascota = new Mascota(); 
            LstMascota = new List<Mascota>();
        }
        public Cliente(string nombre, bool sexo, int codigo,Mascota mascota)
        {
            Nombre = nombre;
            Sexo = sexo;    
            Codigo = codigo;
            Mascota = mascota;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
