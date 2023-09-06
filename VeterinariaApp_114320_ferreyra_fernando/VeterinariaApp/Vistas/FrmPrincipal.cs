using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinariaApp.Vistas;// se agrega  vistas  la carpeta

namespace VeterinariaApp
{
    public partial class fmrPrincipal : Form
    {
        public fmrPrincipal()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hice  click  en nuevo  instanciamos  el frm de nueva  atencion
            fmrNuevaAtencion nuevo=new fmrNuevaAtencion();
            nuevo.ShowDialog();//
        }

        private void fmrPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
