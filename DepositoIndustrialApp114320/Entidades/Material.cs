using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositoIndustrialApp.Entidades
{
    public class Material
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Stock { get; set; }

        public Material()
        {
            Codigo = 0;
            Nombre = "";
            Stock = 0;
        }

        public Material(int codigo, string nombre, decimal stock)
        {
            Codigo = codigo;
            Nombre = nombre;
            Stock = stock;
        }

        public override string ToString()
        {
            return Nombre;
        }

    }
}
