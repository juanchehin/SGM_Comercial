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
    public partial class formTrabajos : Form
    {
        CN_Trabajos objetoCN = new CN_Trabajos();

        private int IdTrabajo;
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public formTrabajos()
        {
            InitializeComponent();
            MostrarTrabajos();
        }

        private void MostrarTrabajos()
        {
            //Console.WriteLine("Entro en mostrar trabajos");
            dataListadoTrabajos.DataSource = objetoCN.MostrarTrabajos();
            // Oculto el IdProducto. Lo puedo seguir usando como parametro de eliminacion
            dataListadoTrabajos.Columns[0].Visible = false;
            lblTotalTrabajos.Text = "Total de Trabajos: " + Convert.ToString(dataListadoTrabajos.Rows.Count);
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "SGM", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SGM", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Eliminar el trabajo", "SGM", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    CN_Trabajos.Eliminar(this.IdTrabajo);
                    this.MostrarTrabajos(); // Creo que no deberia ir, probar borrandolo
                }
                this.MensajeOk("Se elimino de forma correcta el registro");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
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
            this.BuscarTrabajo();
        }

        private void BuscarTrabajo()
        {
            this.dataListadoTrabajos.DataSource = objetoCN.BuscarTrabajo(this.txtBuscar.Text);
            // this.OcultarColumnas();
            lblTotalTrabajos.Text = "Total de Registros: " + Convert.ToString(dataListadoTrabajos.Rows.Count);
        }

        private void btnNuevoTrabajo_Click(object sender, EventArgs e)
        {
            formNuevoEditarTrabajo frm = new formNuevoEditarTrabajo(this.IdTrabajo, true);
            frm.MdiParent = this.MdiParent;
            frm.Show();
            // this.Close();
        }

        private void dataListadoTrabajos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botonEditarListado_Click(object sender, EventArgs e)
        {
            formNuevoEditarTrabajo frm = new formNuevoEditarTrabajo(this.IdTrabajo, false);
            frm.MdiParent = this.MdiParent;
            frm.Show();
            // this.Close();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Eliminar el trabajo", "SGM", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    CN_Trabajos.Eliminar(this.IdTrabajo);
                    this.MostrarTrabajos();
                }
                this.MensajeOk("Se elimino de forma correcta el trabajo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void formTrabajos_Load(object sender, EventArgs e)
        {
            MostrarTrabajos();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.MostrarTrabajos();
        }

        private void dataListadoTrabajos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataListadoTrabajos.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataListadoTrabajos.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataListadoTrabajos.Rows[selectedrowindex];
                this.IdTrabajo = Convert.ToInt32(selectedRow.Cells["IdTrabajo"].Value);
            }
        }
    }
}
