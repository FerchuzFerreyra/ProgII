using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//esto primero
using System.Data.SqlClient;
using VeterinariaApp.Dominio;

namespace VeterinariaApp.Vistas
{
    public partial class fmrNuevaAtencion : Form
    {
        Atencion nuevo;
        public fmrNuevaAtencion()
        {
            InitializeComponent();
            nuevo = new Atencion();
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }

        private void fmrNuevaAtencion_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Today.ToShortDateString();
            txtCliente.Text = "Consumidor final";
            txtCantidad.Text = "1";
            ProximaAtencion();
            CargarMascota();
            CargarDescripcion();
        }

        private void CargarMascota()
        {
            
                SqlConnection conexion = new SqlConnection();
                conexion.ConnectionString = @"Data Source=FERCHUZMKPROGRA\SQLEXPRESS;Initial Catalog=Veterinaria_2023F;Integrated Security=True";
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_CONSULTAR_MASCOTA";
                DataTable tabla = new DataTable();
                tabla.Load(comando.ExecuteReader());//cargar datatable 

                conexion.Close();

                //me manda una lista de productos
                cboMascota.DataSource = tabla;
                cboMascota.ValueMember = tabla.Columns[0].ColumnName;//o se puede escribir "id_producto"
                cboMascota.DisplayMember = tabla.Columns[1].ColumnName;
            
        }

        private void CargarDescripcion()//tipo de animal
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=FERCHUZMKPROGRA\SQLEXPRESS;Initial Catalog=Veterinaria_2023F;Integrated Security=True";
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_CONSULTAR_TIPO_ATENCION";
            DataTable tabla1 = new DataTable();
            tabla1.Load(comando.ExecuteReader());//cargar datatable 

            conexion.Close();

            //me manda una lista de tipos
            cboDescripcionAtencion.DataSource = tabla1;//es el tipo (descripcion)
            cboDescripcionAtencion.ValueMember = tabla1.Columns[0].ColumnName;//o se puede escribir "id_producto"
            cboDescripcionAtencion.DisplayMember = tabla1.Columns[1].ColumnName;// "n_producto"
        }

        private void ProximaAtencion()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=FERCHUZMKPROGRA\SQLEXPRESS;Initial Catalog=Veterinaria_2023F;Integrated Security=True";
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_PROXIMO_ID";//NOMBRE DE LA SP EN LA BD

            //CREO UN PARAMETRO PARA RECIBIR LO QUE MANDA EL PROCEDIMIENTO ALMACENADO. es un parametro de salida
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@next";
            parametro.SqlDbType = SqlDbType.Int; //defino el tipo de parametro que es sql 
            parametro.Direction = ParameterDirection.Output;

            //ahora ejecuto el parametro
            comando.Parameters.Add(parametro);//vinculo el parametro con el comando
            comando.ExecuteNonQuery();

            conexion.Close();

            lblAtencionNro.Text = lblAtencionNro.Text + " " + parametro.Value.ToString();//nombre de la lbl que indica
                                                                                         //el numero de atencion
        }
    }
}
