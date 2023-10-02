using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//agregar using (haciendo referencia a la carpeta presentacion)
//para relacionar los formularios
using DepositoIndustrialApp.Presentacion;
using DepositoIndustrialApp.Servicios;

namespace DepositoIndustrialApp
{
    public partial class FrmPrincipal : Form
    {
        FabricaServicio fabrica = null;//tiene que estar en el global
                                       //para que me lo tome, es un atributo del form
        public FrmPrincipal(FabricaServicio fabrica)
        {
            InitializeComponent();
            this.fabrica = fabrica;
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevaOrden nueva = new FrmNuevaOrden(fabrica);//instanciar nuevo formulario
            nueva.ShowDialog();//para que se cierre la ventana
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
