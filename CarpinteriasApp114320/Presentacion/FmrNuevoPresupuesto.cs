using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CarpinteriasApp.Entidades;

namespace CarpinteriasApp.Presentacion
{
    public partial class FmrNuevoPresupuesto : Form
    {
        Presupuesto nuevo; //necesito un presupuesto para cargar los detalles


        public FmrNuevoPresupuesto()
        {
            InitializeComponent();
            nuevo = new Presupuesto();
        }

        private void FmrNuevoPresupuesto_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Today.ToShortDateString();
            txtCliente.Text = "Consumidor final";
            txtDescuento.Text = "0";
            txtCantidad.Text = "1";
            ProximoPresupuesto();
            CargarProductos();
                
        }

        private void CargarProductos()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=FERCHUZMKPROGRA\SQLEXPRESS;Initial Catalog=CARPINTERIA_2023;Integrated Security=True";
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_CONSULTAR_PRODUCTOS";
            DataTable tabla=new DataTable();
            tabla.Load(comando.ExecuteReader());//cargar datatable 
           
            conexion.Close();

            //me manda una lista de productos
            cboProducto.DataSource = tabla;
            cboProducto.ValueMember = tabla.Columns[0].ColumnName;//o se puede escribir "id_producto"
            cboProducto.DisplayMember=tabla.Columns[1].ColumnName;// "n_producto"
        }

        private void ProximoPresupuesto()//para el numero de presupuesto

        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=FERCHUZMKPROGRA\SQLEXPRESS;Initial Catalog=CARPINTERIA_2023;Integrated Security=True";
            conexion.Open();
            SqlCommand comando=new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_PROXIMO_ID";//NOMBRE DE LA SP EN LA BD

            //CREO UN PARAMETRO PARA RECIBIR LO QUE MANDA EL PROCEDIMIENTO ALMACENADO. es un parametro de salida
            SqlParameter parametro=new SqlParameter();
            parametro.ParameterName = "@next";
            parametro.SqlDbType = SqlDbType.Int; //defino el tipo de parametro que es sql 
            parametro.Direction = ParameterDirection.Output; 

            //ahora ejecuto el parametro
            comando.Parameters.Add(parametro);//vinculo el parametro con el comando
            comando.ExecuteNonQuery();

            conexion.Close();

            lblPresupesto.Text = lblPresupesto.Text+ " " + parametro.Value.ToString();//para q salga el numero del presupuesto pongo.value.tostring



        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un producto...."
                    , "Control"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(txtCantidad.Text) || !int.TryParse(txtCantidad.Text, out _))
            {
                MessageBox.Show("Debe ingresar una cantidad valida...."
                   , "Control"
                   , MessageBoxButtons.OK
                   , MessageBoxIcon.Exclamation);
                return;
            }

            foreach (DataGridViewRow fila in dgvDetalles.Rows)
            {
                if (fila.Cells["ColProducto"].Value.ToString().Equals(cboProducto.Text))
                {
                    MessageBox.Show("El item ya esta presupuestado...."
                   , "Control"
                   , MessageBoxButtons.OK
                   , MessageBoxIcon.Exclamation);
                    return;
                }
            }



            DataRowView item = (DataRowView)cboProducto.SelectedItem;

            int nro = Convert.ToInt32(item.Row.ItemArray[0]);
            string nom = item.Row.ItemArray[1].ToString();
            double pre = Convert.ToDouble(item.Row.ItemArray[2]);

            Producto p = new Producto(nro, nom, pre);

            int cant =Convert.ToInt32(txtCantidad.Text);
            DetallePresupuesto detalle =new DetallePresupuesto(p,cant);

            nuevo.AgregarDetalle(detalle);
            dgvDetalles.Rows.Add(detalle.Producto.ProductoNro,
                                 detalle.Producto.Nombre,
                                 detalle.Producto.Precio,
                                 detalle.Cantidad,
                                 "Quitar");

            CalculaTotales();


        }

        private void CalculaTotales()
        {
            double total = nuevo.CalcularTotal();
            txtSubtotal.Text = total.ToString();
            double dto =total*Convert.ToDouble(txtDescuento.Text) / 100;
            txtTotal.Text = (total-dto).ToString();
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 4)//es el boton quitar
            {
                nuevo.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.RemoveAt(dgvDetalles.CurrentRow.Index);
                CalculaTotales();
            }
        }
    }
}
