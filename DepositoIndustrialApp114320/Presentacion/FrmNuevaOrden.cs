using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using System.Data.SqlClient;
using DepositoIndustrialApp.Entidades;
using DepositoIndustrialApp.Datos;
using DepositoIndustrialApp.Datos.Interfaz;
using DepositoIndustrialApp.Datos.Implementacion;
using DepositoIndustrialApp.Servicios.Interfaz;
using DepositoIndustrialApp.Servicios.Implementacion;
using DepositoIndustrialApp.Servicios;


namespace DepositoIndustrialApp.Presentacion
{
    public partial class FrmNuevaOrden : Form
    {
        IServicio servicio = null;
        IOrdenRetiroDao ord = null;//ordendao
        OrdenRetiro nuevo = null; //necesito un presupuesto para cargar los detalles
        public FrmNuevaOrden(FabricaServicio fabrica)//se hereda a nivel local la fabrica de servicio
        {
            InitializeComponent();
            servicio = fabrica.CrearServicio();//implementando factory
            nuevo = new OrdenRetiro();

        }

        private void FrmNuevaOrden_Load(object sender, EventArgs e)
        {
            dtpFecha.Text = DateTime.Today.ToShortDateString();
            txtResponsable.Text = "";
            txtCantidad.Text = "1";           

            CargarMaterial();
        }

        private void CargarMaterial()
        {
            cboMaterial.DataSource = servicio.TraerMateriales();
            cboMaterial.ValueMember = "Codigo";//o se puede escribir "id_materiales". fijarse en la tabla
            cboMaterial.DisplayMember = "Nombre";// "n_producto"
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)//mapeo
        {
            if (cboMaterial.SelectedIndex == -1)//valido lo que cargo en la grilla
            {
                MessageBox.Show("Debe seleccionar un material...."
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

            foreach (DataGridViewRow fila in dgvDetalles.Rows)//recorre la grilla y ve si el producto existe,
                                                              //si ya esta me llama la atencion
            {
                if (fila.Cells["ColMateriales"].Value.ToString().Equals(cboMaterial.Text))//validacion de que NO SE PUEDE
                                                                                          //agregar el mismo producto
                {
                    MessageBox.Show("El item ya esta cargado...."
                   , "Control"
                   , MessageBoxButtons.OK
                   , MessageBoxIcon.Exclamation);
                    return;
                }
            }
            Material m = (Material)cboMaterial.SelectedItem;//xq el dao me da productos directamente y no la datatable

            int cant = Convert.ToInt32(txtCantidad.Text);
            DetalleOrden detalle = new DetalleOrden(m, cant);//esto es lo que hay de la clase detalle orden

            nuevo.AgregarDetalle(detalle);
            dgvDetalles.Rows.Add(new object[] {m.Nombre, m.Stock, cant, "Quitar" });//este cant es el que se
                                                                                    //ingresa por el txt
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //validar stock suficiente

            //if (int.IsNullOrEmpty(txtResponsable.Text))
            //{
            //    MessageBox.Show("Debe ingresar un Responsable...."
            //      , "Control"
            //      , MessageBoxButtons.OK
            //      , MessageBoxIcon.Exclamation);
            //    return;
            //}

            if (string.IsNullOrEmpty(txtResponsable.Text))
            {
                MessageBox.Show("Debe ingresar un Responsable...."
                  , "Control"
                  , MessageBoxButtons.OK
                  , MessageBoxIcon.Exclamation);
                return;
            }

            if (dgvDetalles.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un Detalle...."
                   , "Control"
                   , MessageBoxButtons.OK
                   , MessageBoxIcon.Exclamation);
                return;
            }

            //confirmar o grabar
            GrabarPresupuesto();
        }

        private void GrabarPresupuesto()
        {

            nuevo.Fecha = Convert.ToDateTime(dtpFecha.Text);
            nuevo.Responsable = txtResponsable.Text;
            
            if (servicio.CrearOrden(nuevo))
            {
                MessageBox.Show("Se registro con exito la orden...."
                  , "Informe"
                  , MessageBoxButtons.OK
                  , MessageBoxIcon.Exclamation);

                this.Dispose();

            }
            else
            {
                MessageBox.Show("No se pudo registrar orden...."
                  , "Error"
                  , MessageBoxButtons.OK
                  , MessageBoxIcon.Exclamation);
            }
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 3)//es el boton quitar
            {
                nuevo.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.RemoveAt(dgvDetalles.CurrentRow.Index);
                
            }
        }
    }
    
}

//Al registrar una orden se deberá mostrar un mensaje de confirmación
//indicando el número generado y la pantalla deberá quedar lista para una
//nueva carga.