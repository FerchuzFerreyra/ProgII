using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//se agrega esto
using System.Data;
using System.Data.SqlClient;


namespace DepositoIndustrialApp.Datos
{
    public class HelperDao
    {
        private static HelperDao instancia;//creamos una instancia para el metodo singleton
                                           //(SE LLAMA A esta conexion cada vez que la queremos usar)
        private SqlConnection conexion;//iniciar siempre en el constructor

        public HelperDao()
        {
            conexion = new SqlConnection(Properties.Resources.CadenaConexion);//conectamos con el cadena conexion
                                                                              //de la properties
        }

        public static HelperDao ObtenerInstancia() //ESTO ES EL SINGLETON (publico y estatico)
                                                   //cuando quiera usar el helper voy a llamar
                                                   //al metodo obtener instancia
        {
            if (instancia == null)
            {
                instancia = new HelperDao();//si el helperdao es nulo, me crea una nueva conexion
            }
            return instancia;
        }

        public SqlConnection ObtenerConexion()//se usa obtenerinstancia.obtenerconexion para conectarnos
        {
            return this.conexion;//retorna la cadenaconexion de la properties
        }

        public DataTable Consultar(string nombreSP)//para cargar el combo o consultar datos de la base de datos
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
        }

  

    }
}
