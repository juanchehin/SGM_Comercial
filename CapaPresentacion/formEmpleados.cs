using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Agregados
using CapaNegocio;
// using System.DateTime;

namespace CapaPresentacion
{
    public partial class formEmpleados : Form
    {
        CN_Empleados objetoCN = new CN_Empleados();

        private int IdEmpleado;
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public formEmpleados()
        {
            InitializeComponent();
        }

        private void formEmpleados_Load(object sender, EventArgs e)
        {
            MostrarEmpleados();
        }
        private void MostrarEmpleados()
        {
            dataListadoEmpleados.DataSource = objetoCN.MostrarEmp();
            // Oculto el IdEmpleado. Lo puedo seguir usando como parametro de eliminacion
            dataListadoEmpleados.Columns[0].Visible = false;
            lblTotalEmpleados.Text = "Total de Registros: " + Convert.ToString(dataListadoEmpleados.Rows.Count);

            // dataListadoEmpleados.Columns[0].ReadOnly = true;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }
        //Limpiar todos los controles del formulario

        //Mostrar Mensaje de Confirmación
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "SGM", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SGM", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataListadoEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("e.ColumnIndex " + e.ColumnIndex);    // Dice que columna se hizo click
            if (e.ColumnIndex == dataListadoEmpleados.Columns["Marcar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dataListadoEmpleados.Rows[e.RowIndex].Cells["Marcar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarEmpleado();
        }

        private void BuscarEmpleado()
        {
            Console.WriteLine("this.txtBuscar.Text es " + this.txtBuscar.Text);
            this.dataListadoEmpleados.DataSource = objetoCN.BuscarEmpleado(this.txtBuscar.Text);
            // this.OcultarColumnas();
            lblTotalEmpleados.Text = "Total de Registros: " + Convert.ToString(dataListadoEmpleados.Rows.Count);
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            Console.WriteLine("this.IdEmpleado en click nuevo es  : " + this.IdEmpleado);
            formNuevoEditarEmpleado frm = new formNuevoEditarEmpleado(this.IdEmpleado, true);
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Close();
        }

        private void botonEditarListado_Click(object sender, EventArgs e)
        {
            formNuevoEditarEmpleado frm = new formNuevoEditarEmpleado(this.IdEmpleado, false);
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Close();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Eliminar el empleado", "SGM", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    Console.WriteLine("El IdEmpleado en eliminar es " + this.IdEmpleado);
                    CN_Empleados.Eliminar(this.IdEmpleado);
                    this.MostrarEmpleados();
                    this.MensajeOk("Se elimino de forma correcta el registro");
                }
                txtBuscar.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dataListadoEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            if (dataListadoEmpleados.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataListadoEmpleados.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataListadoEmpleados.Rows[selectedrowindex];
                this.IdEmpleado = Convert.ToInt32(selectedRow.Cells["IdEmpleado"].Value);
            }
        }

        private void btnAgregarTrabajos_Click(object sender, EventArgs e)
        {
            // this.Close();
            formTrabajosEmpleado frm = new formTrabajosEmpleado(this.IdEmpleado,1);
            frm.MdiParent = this.MdiParent;
            frm.Show();
            // this.Close();
        }

        private void btnAgregarTrabajo_Click(object sender, EventArgs e)
        {
            this.agregarTrabajo(this.IdEmpleado);
        }

        private void agregarTrabajo(int IdEmpleado)
        {
            formAgregarTrabajoEmpleado frm = new formAgregarTrabajoEmpleado(this.IdEmpleado);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar_Click(this, new EventArgs());
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.MostrarEmpleados();
        }
    }

}
