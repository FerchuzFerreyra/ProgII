using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using DepositoIndustrialApp.Entidades;
using DepositoIndustrialApp.Datos.Interfaz;
using System.Data;
using System.Data.SqlClient;


namespace DepositoIndustrialApp.Datos.Implementacion
{
    public class OrdenRetiroDao : IOrdenRetiroDao
    {
       
        public bool Crear(OrdenRetiro oOrden)//nuestro confirmar presupuesto, creando tabla maestra
        {
            bool resultado = true;
            SqlConnection conexion = HelperDao.ObtenerInstancia().ObtenerConexion();

            SqlTransaction t = null;
            try
            {
                //insert orden (maestro)
                conexion.Open();
                t = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.Transaction = t;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_INSERTAR_ORDEN";
                comando.Parameters.AddWithValue("@responsable", oOrden.Responsable);//parametro de entrada


                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@nro";//parametro de salida
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parametro);

                comando.ExecuteNonQuery();

                //insert del detalle
                int ordenNro = (int)parametro.Value;
                int detalleNro = 1;//filas de la grilla
                SqlCommand cmdDetalle;//comando

                foreach (DetalleOrden det in oOrden.Detalles)
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLES", conexion, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@nro_orden", ordenNro);
                    cmdDetalle.Parameters.AddWithValue("@detalle", detalleNro);
                    cmdDetalle.Parameters.AddWithValue("@codigo", det.Material.Codigo);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", det.Cantidad);
                    cmdDetalle.ExecuteNonQuery();
                    detalleNro++;//cuenta las filas del detalle
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

        public List<Material> ObtenerMateriales()//desarrollo el metodo obtenermateriales,
                                                 //que viene de traer materiales de la interfaz
                                                 //carar el combo
        {
            List<Material> lMateriales = new List<Material>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_CONSULTAR_MATERIALES");//los metodosa del dao buscan
                                                                                                //el herlperdao para usar la conexion
            //mapear un registro de la tabla a un objeto del modelo del dominio

            foreach (DataRow fila in tabla.Rows)
            {
                int codigo = int.Parse(fila["codigo"].ToString());
                string nombre = fila["nombre"].ToString();
                decimal stock = decimal.Parse(fila["stock"].ToString());
                                
                Material m = new Material(codigo, nombre, stock);
               
                lMateriales.Add(m);

            }
            return lMateriales;
        }


    }
}
