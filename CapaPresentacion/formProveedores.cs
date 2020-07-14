using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class formProveedores : Form
    {
        CN_Proveedores objetoCN = new CN_Proveedores();

        private int IdProveedor;
        public formProveedores()
        {
            InitializeComponent();
            MostrarProveedores();
        }


        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar_Click(this, new EventArgs());
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarProveedor();
        }

        private void BuscarProveedor()
        {
            Console.WriteLine("this.txtBuscar.Text es " + this.txtBuscar.Text);
            this.dataListadoProveedores.DataSource = objetoCN.BuscarProveedor(this.txtBuscar.Text);
            // this.OcultarColumnas();
            lblTotalProveedores.Text = "Total de Registros: " + Convert.ToString(dataListadoProveedores.Rows.Count);
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.MostrarProveedores();
        }

        public void MostrarProveedores()
        {
            // Console.WriteLine("Ahora va el mostrar productos");
            dataListadoProveedores.DataSource = objetoCN.MostrarProveedores();
            dataListadoProveedores.Columns[0].Visible = false;
            lblTotalProveedores.Text = "Total de Registros: " + Convert.ToString(dataListadoProveedores.Rows.Count);
            // this.banderaFormularioHijo = false;
        }

        private void botonEditarListado_Click(object sender, EventArgs e)
        {
            formNuevoEditarProveedor frm = new formNuevoEditarProveedor(this.IdProveedor, false);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void dataListadoProveedores_SelectionChanged(object sender, EventArgs e)
        {
            if (dataListadoProveedores.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataListadoProveedores.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataListadoProveedores.Rows[selectedrowindex];
                this.IdProveedor = Convert.ToInt32(selectedRow.Cells["IdProveedor"].Value);
                Console.WriteLine("El IdProveedor es " + this.IdProveedor);
            }
        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            formNuevoEditarProveedor frm = new formNuevoEditarProveedor(this.IdProveedor, true);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Eliminar el proveedor", "SGM", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    CN_Proveedores.Eliminar(this.IdProveedor);
                    this.MostrarProveedores();
                    this.MensajeOk("Se elimino de forma correcta el proveedor");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            // this.Close();
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "SGMn", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SGM", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
