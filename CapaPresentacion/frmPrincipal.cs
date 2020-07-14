using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formClientes frm = new formClientes();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formProductos frm = new formProductos();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            formEmpleados frm = new formEmpleados();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void txtSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            formProveedores frm = new formProveedores();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            formCompras frm = new formCompras();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            formVentas frm = new formVentas();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnTrabajos_Click(object sender, EventArgs e)
        {
            formTrabajos frm = new formTrabajos();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            formInformacion frm = new formInformacion();
            frm.Show();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.ttAyuda.SetToolTip(btnAyuda, "Ayuda");
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
