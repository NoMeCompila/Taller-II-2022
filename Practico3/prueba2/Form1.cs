using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba2
{
    public partial class MDIForm : Form
    {
        public MDIForm()
        {
            InitializeComponent();
        }

        private void administrarCleintesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = this.MdiChildren.FirstOrDefault(x => x is FormClientes);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }



            FormClientes formulario_clientes = new FormClientes();
            formulario_clientes.MdiParent = this;
            formulario_clientes.Show();
        }

        private void menuStrip1_BackColorChanged(object sender, EventArgs e)
        {

        }
    }
}
