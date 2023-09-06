using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CARRERASAPP.Datos;
using CARRERASAPP.Entidades;

namespace CARRERASAPP.Presentacion
{
    public partial class FrmNuevaCarrera : Form
    {
        DBHelper gestor;
        Carrera nuevo;

        public FrmNuevaCarrera()
        {
            InitializeComponent();
            gestor = new DBHelper();
            nuevo = new Carrera();
        }

        private void FrmNuevaCarrera_Load(object sender, EventArgs e)
        {
            txtNombreCarrera.Text = string.Empty;
            txtAnioCursado.Text = "1";
            CargarMaterias();

        }

        private void CargarMaterias()
        {
            DataTable tabla = gestor.ConsultarSP("sp_consultar_asignaturas");
            cboMaterias.DataSource = tabla;
            cboMaterias.ValueMember = tabla.Columns[0].ColumnName;
            cboMaterias.DisplayMember = tabla.Columns[1].ColumnName;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombreCarrera.Text == "")
            {
                MessageBox.Show("Ingrese el nombre de la carrera", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cboMaterias.SelectedItem.Equals(String.Empty))
            {
                MessageBox.Show("seleccione una materia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtAnioCursado.Text == "")
            {
                MessageBox.Show("Debe ingresar un año de cursado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!rbnPrimerCuatrimestre.Checked && !rbnSegundoCuatrimestre.Checked)
            {
                MessageBox.Show("Debe seleccionar un cuatrimestre", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            foreach (DetalleCarreras dc in nuevo.DetallesCarrera)
            {
                if (dc.Asignatura.Nombre == cboMaterias.Text)
                {
                    MessageBox.Show("Solo puede agregar una vez cada materia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            DataRowView item = (DataRowView)cboMaterias.SelectedItem;

            Asignatura asignatura = new Asignatura();
            asignatura.Id_asignatura = Convert.ToInt32(item.Row.ItemArray[0]);
            asignatura.Nombre = item.Row.ItemArray[1].ToString();
            int AnioCursado= int.Parse(txtAnioCursado.Text);//esto es lo que yo ingreso manualmente en el txt anio de cursado
            int Cuatrimestre = 0;//esto es lo que ingreso yo a traves del radiobutton por eso es cero 
            if (rbnPrimerCuatrimestre.Checked) Cuatrimestre = 1;
            if (rbnSegundoCuatrimestre.Checked) Cuatrimestre = 2;

            DetalleCarreras detCarrera = new DetalleCarreras(AnioCursado,Cuatrimestre,asignatura);
            nuevo.AgregarDetalle(detCarrera);//nuevo es lo que inicialice en un comienzo la carrera
            dgvDetalleCarrera.Rows.Add(new object[] {asignatura.Id_asignatura,asignatura.Nombre,AnioCursado,Cuatrimestre});//Agregamos a la grilla

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombreCarrera.Text == "")
            {
                MessageBox.Show("Ingrese el nombre de la carrera",
                "Atención", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            bool id_carrera = gestor.ConfirmarAsignatura(nuevo);
            MessageBox.Show("La carrera ha sido agregada", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        
    }
}
