using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CARRERASAPP.Entidades;


namespace CARRERASAPP.Datos
{
    internal class DBHelper
    {
        private SqlConnection conexion;
        private SqlCommand comando=new SqlCommand();

        public DBHelper()
        {
            conexion = new SqlConnection("Data Source=leti_mauri;Initial Catalog=CarrerasBD_Local;Integrated Security=True");
        }

        private void ConfigurarComando()
        {
            comando.Connection = conexion;
            
            comando.CommandType= CommandType.StoredProcedure;
        }

        public DataTable ConsultarSP(string SPNombre)
        {
            DataTable tabla=new DataTable();
            conexion.Open();
            ConfigurarComando();
            comando.CommandText = SPNombre;
            tabla.Load(comando.ExecuteReader());
            conexion.Close();

            return tabla;
        }

        public DataTable Consultar(string nombreSP, List<Parametros> lstParametros)
        {
            conexion.Open();
            ConfigurarComando();
            comando.CommandText = nombreSP;
            comando.Parameters.Clear();
            foreach (Parametros p in lstParametros)
            {
                comando.Parameters.AddWithValue(p.Nombre, p.Valor);
            }
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
        }

        public bool ConfirmarAsignatura(Carrera oCarrera)
        {
            bool resultado = true;

            SqlTransaction t = null;
            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                ConfigurarComando();
                comando.Transaction = t;
                comando.CommandText = "sp_insertar_carrera";
                comando.Parameters.AddWithValue("@new_id_carrera", oCarrera.Id_Carrera);
                comando.Parameters.AddWithValue("@nombre", oCarrera.NombreTitulo);
                
                

                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@new_id_carrera";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parametro);

                comando.ExecuteNonQuery();

                int id_Carrera = (int)parametro.Value;
                int detalleNro = 1;
                SqlCommand cmdDetalle;

                foreach (DetalleCarreras dp in oCarrera.DetallesCarrera)
                {
                    cmdDetalle = new SqlCommand("sp_insertar_detalleCarreras", conexion, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@anioCursado", dp.AnioCursado);
                    cmdDetalle.Parameters.AddWithValue("@cuatrimestr", dp.Cuatrimestre);
                    cmdDetalle.Parameters.AddWithValue("@id_carrera", oCarrera.Id_Carrera);
                    cmdDetalle.Parameters.AddWithValue("@id_asignatura", dp.Asignatura);
                    cmdDetalle.ExecuteNonQuery();
                    detalleNro++;
                }
                t.Commit();
            }
            catch
            {
                if (t != null)
                    t.Rollback();
                resultado = false;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return resultado;
        }




    }
}
