using CarpinteriasApp.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarpinteriasApp
{
    public partial class FmrPrincipal : Form
    {
        public FmrPrincipal()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrNuevoPresupuesto nuevo = new FmrNuevoPresupuesto();
            nuevo.ShowDialog();     // uso el showdialog para que pueda cerrar primero el formulario nuevo presupuesto y despues el principal.
                                    //si uso el show solo puedo cerrar los dos formularios desde el principal ADEMAS NO PUEDE ABRIR MUCHAS VECES EL FORMULARIO

        }

        private void FmrPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
